using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RainbowColor : MonoBehaviour
{
    public Color[] Formation;
    public Color Clr;
    public bool[] Text;
    public GameObject[] Object;
    public bool[] Enabled;

    void Start()
    {
        Restart();
    }

    void Update()
    {
        
    }

    private void Restart()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        for (int i = 0; i < Formation.Length; i++)
        {
            for (int obj = 0; obj < Object.Length; obj++)
            {
                if (Enabled[obj] == true)
                {
                    if (Text[obj] == false)
                    {
                        Object[obj].GetComponent<Image>().color = Formation[i];
                    }
                    else
                    {
                        Object[obj].GetComponent<TextMeshProUGUI>().color = Formation[i];
                    }
                    Clr = Formation[i];
                    yield return new WaitForSeconds(0.1f);
                }
            }
        }
        Restart();
    }
}
