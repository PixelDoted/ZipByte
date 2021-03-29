using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemesHandler : MonoBehaviour
{

    public GameObject[] Themes; // The Shop Item
    public Vector2[] Time; // x: Day, y: Month

    private float Day; // This Day
    private float Month; // This Month

    void Start()
    {
        Day = System.DateTime.Today.Day;
        Month = System.DateTime.Today.Month;
    }

    void LateUpdate()
    {
        if (System.DateTime.Today.Day != Day)
        {
            Day = System.DateTime.Today.Day;
            Month = System.DateTime.Today.Month;
        }

        for (int id = 0; id < Themes.Length; id++)
        {
            if (Day == Time[id].x && Month == Time[id].y)
            {
                Themes[id].SetActive(true);
            }
            else if (Time[id].x == 0 && Month == Time[id].y)
            {
                Themes[id].SetActive(true);
            }
        }
    }
}
