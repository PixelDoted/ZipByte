using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomShapes : MonoBehaviour
{
    public int MaxPoints;
    public int MinPoints;
    public float XLimit;
    public float YLimit;
    public GameObject Line;
    public GameObject Point;
    public GameObject ImplodeGray;
    public LineRenderer RenderLine;
    public bool AllowLastPos = true;
    private Vector2 Pos;
    private int wantedamount;
    private bool Loaded = false;
    private Vector2 LastPos;
    private bool isLast = false;

    private float Py = 0, Px = 0;

    void Start()
    {

    }

    public void LoadLine()
    {
        Loaded = true;
        RenderLine.positionCount = 0;
        wantedamount = Random.Range(MinPoints, MaxPoints);
        for (int amount = 0; amount < wantedamount; amount++)
        {
            Pos = new Vector2(Mathf.Ceil(Random.Range(-XLimit, XLimit)), Mathf.Ceil(Random.Range(-YLimit, YLimit)));
            if (isLast == true && AllowLastPos == true)
            {
                Px = Pos.x;
                Py = Pos.y;
                Clamp();
                Pos = new Vector2(LastPos.x - Px, LastPos.y - Py);
            }
            GameObject PointObj = Instantiate(Point, Pos, Point.transform.rotation);
            PointObj.transform.parent = Line.transform;
            PointObj.GetComponent<Destroy>().implodeGray = ImplodeGray;
            PointObj.GetComponent<Destroy>().Main = Line;
            Line.GetComponent<Handler>().Add(amount + 1, PointObj);
            RenderLine.positionCount = amount + 1;
            RenderLine.SetPosition(amount, Pos);
            LastPos = Pos;
            isLast = true;
        }
        wantedamount = 0;
    }

    public void ClearLine()
    {
        Loaded = false;
        Line.GetComponent<Handler>().MaxPoints = 1;
        for (int i = 0; i < Line.GetComponent<Handler>().Points.Length; i++)
        {
            Destroy(Line.GetComponent<Handler>().Points[i]);
            isLast = false;
        }
        Line.GetComponent<Handler>().Clear("Points");
    }

    public void Clamp()
    {
        if (Px > 0)
        {
            Px = 1;
        }
        else if (Px < 0)
        {
            Px = -1;
        }
        if (Py > 0)
        {
            Py = 1;
        }
        else if (Py < 0)
        {
            Py = -1;
        }
        if (Py == 0 && Px == 0)
        {
            Py = 1;
            Px = -1;
        }
    }

    public bool isLoaded()
    {
        return Loaded;
    }
}
