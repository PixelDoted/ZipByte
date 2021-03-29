using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler : MonoBehaviour
{

    public float Destroyed = 0;
    public float MaxPoints;
    public GameObject implodeWhite;
    public GameObject[] Points;

    public Spawner spawn;
    private bool Stop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Destroyed == MaxPoints)
        {
            spawn.Destroyed = true;
            Stop = false;
            spawn.Loader = true;
            Destroyed = 0;
            implodeWhite.SetActive(true);
            Instantiate(implodeWhite, transform.position, transform.rotation);
            implodeWhite.SetActive(false);
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].SetActive(true);
            }
            this.gameObject.SetActive(false);
        }
        else if (spawn.Stopped == true && Stop == false) {
            Stop = true;
            Destroyed = 0;
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].SetActive(true);
            }
            this.gameObject.SetActive(false);
        }
    }

    public void reset()
    {
        Destroyed = 0;
        for (int i = 0; i < Points.Length; i++)
        {
            Points[i].SetActive(true);
        }
    }

    public Spawner getSpawn()
    {
        return spawn;
    }

    public void Clear(string type)
    {
        if (type == "Points")
        {
            Points = new GameObject[1];
        }
    }

    public void Add(int array, GameObject obj)
    {
        GameObject[] temp = new GameObject[array];
        Points.CopyTo(temp, 0);
        temp[array - 1] = obj;
        Points = temp;
    }
}
