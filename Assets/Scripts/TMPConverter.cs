using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TMPConverter : MonoBehaviour
{
    public TextMeshProUGUI[] TO;
    public Text[] FROM;
    public string[] Symble;
    void LateUpdate()
    {
        for (int i = 0; i < TO.Length; i++)
        {
            TO[i].SetText(FROM[i].text + Symble[i]);
        }
    }
}
