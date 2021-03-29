using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Destroy : MonoBehaviour
{

    public GameObject implodeGray;
    public GameObject Main;
    public float clickBuffer = 1;

    private bool clicked;
    private Collider2D col;

    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    //void OnMouseDown()
    //{
    //    clicked = true;
    //}

    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            if(touch.phase == TouchPhase.Began) {
                Camera.main.GetComponent<ScriptCamera>().Pause = true;
                //Collider2D touchedCol = Physics2D.OverlapPoint(touchPos);
                Collider2D touchedCol = Physics2D.OverlapCircle(touchPos, clickBuffer);
                if (col == touchedCol)
                {
                    clicked = true;
                }
                Camera.main.GetComponent<ScriptCamera>().Pause = false;
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Camera.main.GetComponent<ScriptCamera>().Pause = true;
            //Collider2D touchedCol = Physics2D.OverlapPoint(clickPos);
            Collider2D touchedCol = Physics2D.OverlapCircle(clickPos, clickBuffer);
            if (col == touchedCol)
            {
                clicked = true;
            }
            Camera.main.GetComponent<ScriptCamera>().Pause = false;
        }

        if (clicked == true)
        {
            if (!(Main.GetComponent<Handler>().getSpawn().Paused == true))
            {
                implodeGray.SetActive(true);
                GameObject implode = Instantiate(implodeGray, transform.position, transform.rotation);
                implodeGray.SetActive(false);
                Main.GetComponent<Handler>().Destroyed += 1;
                Main.GetComponent<Handler>().getSpawn().Scores.Score = Main.GetComponent<Handler>().getSpawn().Scores.Score + Main.GetComponent<Handler>().getSpawn().Scores.AddScore;
                this.gameObject.SetActive(false);
            }
            clicked = false;
        }
    }
}
