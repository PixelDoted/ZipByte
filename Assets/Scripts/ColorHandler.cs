using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorHandler : MonoBehaviour
{
    public GameObject[] Objects;
    public int BackgroundID = 0;
    public int MusicID1 = 1, MusicID2 = 2;
    public int PointsID = 3, HandlerID = 4;
    public Slider[] Back = new Slider[3];
    public Slider[] Music = new Slider[3];

    void LateUpdate()
    {
        UpdateColors();
    }

    public void UpdateColors()
    {
        Color BackClr = Color.white;
        BackClr.r = Back[0].value;
        BackClr.g = Back[1].value;
        BackClr.b = Back[2].value;
        Objects[BackgroundID].GetComponent<SpriteRenderer>().color = BackClr;
        Color MusicClr = Color.white;
        MusicClr.r = Music[0].value;
        MusicClr.g = Music[1].value;
        MusicClr.b = Music[2].value;
        Objects[MusicID1].GetComponent<LineRenderer>().startColor = MusicClr;
        Objects[MusicID1].GetComponent<LineRenderer>().endColor = MusicClr;
        Objects[MusicID2].GetComponent<LineRenderer>().startColor = MusicClr;
        Objects[MusicID2].GetComponent<LineRenderer>().endColor = MusicClr;
    }
}
