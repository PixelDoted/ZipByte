using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Objects;
    public GameObject Shape;
    public Sprite[] Sprite;
    public Scores Scores;
    public Timer Timer;
    public Vector3[] ShapeSizes;

    public float Time;
    public float Ran;
    public bool Loader;
    public bool Stopper;
    public bool Pauser;
    public bool Resumer;
    public bool Paused;
    public bool Stopped;

    public bool LevelUpped;
    public bool LevelUpd;
    public bool Destroyed;
    public int ForceType = 0;

    private float LastRad;


    void Update()
    {
        if(Loader == true)
        {
            Stopped = false;
            Loader = false;
            Load();
        }
        if (Stopper == true)
        {
            Stopper = false;
            Stop();
        }
        if (Pauser == true)
        {
            Pauser = false;
            Pause();
        }
        if (Resumer == true)
        {
            Resumer = false;
            Resume();
        }
        if (LevelUpped == true)
        {
            StartCoroutine(LevelUp());
            LevelUpped = false;
        }
    }

    public void Load()
    {
        Shape.SetActive(true);
        GameObject Obj = Objects[0];
        int rad = Random.Range(0, Objects.Length);
        if(ForceType != 0)
        {
            rad = ForceType;
        }

        Obj = Objects[rad];
        Shape.GetComponent<SpriteRenderer>().sprite = Sprite[rad];
        Shape.transform.localScale = ShapeSizes[rad];

        if (rad != LastRad)
        {
            LastRad = rad;
            Obj.SetActive(true);
            float rot = Random.Range(0, 360);
            Obj.transform.rotation = Quaternion.Euler(0, 0, rot);
            Shape.transform.rotation = Quaternion.Euler(0, 0, rot);
            Ran = rad;
        }
        else { Load(); }
        Timer.StartTimer = true;
        Timer.GameTime = 0;
        Destroyed = false;
    }

    public void Stop()
    {
        Stopped = true;
        Shape.SetActive(false);
        for (int i = 0; i < Objects.Length; i++)
        {
            Handler Hand = Objects[i].GetComponent<Handler>();
            Hand.reset();
            Objects[i].SetActive(false);
        }
    } 

    public void Pause()
    {
        Paused = true;
    }

    public void Resume()
    {
        Paused = false;
    }

    IEnumerator LevelUp()
    {
        LevelUpd = true;
        yield return new WaitForSeconds(1f);
        LevelUpd = false;
    }
}
