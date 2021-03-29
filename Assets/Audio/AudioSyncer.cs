using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSyncer : MonoBehaviour
{

    protected bool m_isBeat;

    private float m_timer;
    private float m_audioValue;
    private float m_previousAudioValue;

    public float restSmoothTime;
    public float timeToBeat;
    public float timeStep;
    public float bias;

    private void Update()
    {
        OnUpdate();
    }

    public virtual void OnUpdate()
    {
        m_previousAudioValue = m_audioValue;
        m_audioValue = AudioSpectrum.SpectrumValue;
        if (m_previousAudioValue > bias && m_audioValue <= bias)
        {
            if (m_timer > timeStep)
            {
                OnBeat();
            }
        }

        if (m_previousAudioValue <= bias && m_audioValue > bias)
        {
            if (m_timer > timeStep)
            {
                OnBeat();
            }
        }
        m_timer += Time.deltaTime;
    }

    public virtual void OnBeat()
    {
        //Debug.Log("beat");
        m_timer = 0;
        m_isBeat = true;
    }
}
