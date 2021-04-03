using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Destroy : MonoBehaviour
{

    public GameObject implodeGray;
    public GameObject Main;

    private Collider2D col;

    void Start() {
        col = GetComponent<Collider2D>();
    }

    //void OnMouseDown()
    //{
    //    clicked = true;
    //}

    public void onClick() {
        if (!(Main.GetComponent<Handler>().getSpawn().Paused == true))
        {
            implodeGray.SetActive(true);
            GameObject implode = Instantiate(implodeGray, transform.position, transform.rotation);
            implodeGray.SetActive(false);
            Main.GetComponent<Handler>().Destroyed += 1;
            Main.GetComponent<Handler>().getSpawn().Scores.Score = Main.GetComponent<Handler>().getSpawn().Scores.Score + Main.GetComponent<Handler>().getSpawn().Scores.AddScore;
            this.gameObject.SetActive(false);
        }
    }
}
