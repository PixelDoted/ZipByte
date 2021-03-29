using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedOp : MonoBehaviour
{
    public int LowestLevel;

    private void Start()
    {
        QualitySettings.SetQualityLevel(LowestLevel);
    }

    public void QualitySetting(int ID)
    {
        QualitySettings.SetQualityLevel(ID);
    }
}
