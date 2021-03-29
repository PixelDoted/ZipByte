using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSyncPosition : AudioSyncer
{
    public Vector3 restPosition;
    public Vector3 beatPosition;

    public override void OnBeat()
    {
        base.OnBeat();

        StopCoroutine("MoveToPosition");
        StartCoroutine("MoveToPosition", beatPosition);
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (m_isBeat) return;

        transform.localPosition = Vector3.Lerp(transform.localPosition, restPosition, restSmoothTime * Time.deltaTime);
    }

    private IEnumerator MoveToPosition(Vector3 _target)
    {
        Vector3 _curr = transform.localPosition;
        Vector3 _initial = _curr;
        float _timer = 0;

        while (_curr != _target)
        {
            _curr = Vector3.Lerp(_initial, _target, _timer / timeToBeat);
            _timer += Time.deltaTime;

            transform.localPosition = _curr;

            yield return null;
        }
        m_isBeat = false;
    }
}
