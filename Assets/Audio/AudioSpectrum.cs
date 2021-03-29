﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpectrum : MonoBehaviour
{

    private float[] m_audioSpectrum;

    public static float SpectrumValue { get; private set; }

    void Start()
    {
        m_audioSpectrum = new float[128];
    }

    void Update()
    {
        AudioListener.GetSpectrumData(m_audioSpectrum, 0, FFTWindow.Hanning);

        if (m_audioSpectrum != null && m_audioSpectrum.Length > 0)
        {
            SpectrumValue = m_audioSpectrum[0] * 100;
        }
    }
}
