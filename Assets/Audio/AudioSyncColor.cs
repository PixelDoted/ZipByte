using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(LineRenderer))]
public class AudioSyncColor : AudioSyncer
{
    private LineRenderer m_line;
    private int m_randomIndx;
    private Color LineColor;

    public Color restColor;
    public Color[] beatColors;

    void Start()
    {
        m_line = this.GetComponent<LineRenderer>();
    }

    public override void OnBeat()
    {
        base.OnBeat();

        Color _c = RandomColor();

        StopCoroutine("MoveToColor");
        StartCoroutine("MoveToColor", _c);
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (m_isBeat) return;

        m_line.material = new Material(Shader.Find("Sprites/Default"));

        LineColor = Color.Lerp(LineColor, restColor, restSmoothTime * Time.deltaTime);
        m_line.startColor = LineColor;
        m_line.endColor = LineColor;
    }

    private Color RandomColor()
    {
        if (beatColors == null || beatColors.Length == 0) return Color.white;
        m_randomIndx = Random.Range(0, beatColors.Length);
        return beatColors[m_randomIndx];
    }

    private IEnumerator MoveToColor(Color _target)
    {
        Color _curr = LineColor;
        Color _initial = _curr;
        float _timer = 0;

        while (_curr != _target)
        {
            _curr = Color.Lerp(_initial, _target, _timer / timeToBeat);
            _timer += Time.deltaTime;

            m_line.material = new Material(Shader.Find("Sprites/Default"));
            LineColor = _curr;
            m_line.startColor = LineColor;
            m_line.endColor = LineColor;

            yield return null;
        }
        m_isBeat = false;
    }
}
