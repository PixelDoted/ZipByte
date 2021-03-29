using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

    public Spawner spawn;
    public GameObject MMenu;
    public GameObject MHUD;
    public GameObject MPause;
    public GameObject MShop;
    public GameObject MOptions;
    public GameObject Fade;
    public Image imgFade;
    public Scores score;
    public float ScoreDelTime = 0.05f;
    public bool Quited;
    public Timer TimeGame;

    void Start ()
    {
        StartCoroutine(FadeIn(false));
    }

    void Update()
    {
        if (Input.GetButtonDown("Quit"))
        {
            score.SaveQuit();
            Application.Quit();
        }
        if (Quited == true)
        {
            Quited = false;
            Quit();
        }
    }

    public void Play()
    {
        StartCoroutine(FadeOut("Play"));
        StartCoroutine(DelScore());
    }

    public void Watch()
    {
        
    }

    public void Pause()
    {
        TimeGame.StartTimer = false;
        spawn.Pauser = true;
        MHUD.SetActive(false);
        MPause.SetActive(true);
    }

    public void resume()
    {
        TimeGame.StartTimer = true;
        spawn.Resumer = true;
        MHUD.SetActive(true);
        MPause.SetActive(false);
    }

    public void Quit()
    {
        TimeGame.GameTime = 0;
        score.SaveQuit();
        StartCoroutine(FadeOut("Quit"));
    }

    public void Exit()
    {
        score.SaveQuit();
        Application.Quit();
    }

    public void Options()
    {
        StartCoroutine(FadeOut("Options"));
    }
    public void Shop()
    {
        StartCoroutine(FadeOut("Shop"));
    }
    public void MenuShop()
    {
        score.SaveQuit();
        StartCoroutine(FadeOut("Menu"));
    }

    IEnumerator DelScore()
    {
        float Counting = ScoreDelTime;
        while (score.Score != 0)
        {
            score.Score -= 1;
            yield return new WaitForSeconds(Counting);
            Counting = Counting - 0.005f;
        }
    }

    public void Reward()
    {
        score.Coins += score.ADCoins;
    }

    IEnumerator FadeOut(string change)
    {
        Fade.SetActive(true);
        imgFade.canvasRenderer.SetAlpha(0.0f);
        imgFade.CrossFadeAlpha(1,1,false);
        yield return new WaitForSeconds(1f);
        bool Play = false;
        if (!(change == null))
        {
            if (change == "Play")
            {
                score.Score = 0;
                Play = true;
                spawn.Loader = true;
                spawn.Pauser = true;
                MMenu.SetActive(false);
                MHUD.SetActive(true);
            }
            else if (change == "Quit")
            {
                MHUD.SetActive(false);
                spawn.Resumer = true;
                spawn.Stopper = true;
                MPause.SetActive(false);
                MMenu.SetActive(true);
            }
            else if (change == "Shop")
            {
                MShop.SetActive(true);
                MMenu.SetActive(false);
            }
            else if (change == "Menu")
            {
                MShop.SetActive(false);
                MOptions.SetActive(false);
                MMenu.SetActive(true);
            }
            else if (change == "Options")
            {
                MOptions.SetActive(true);
                MMenu.SetActive(false);
            }
        }
        StartCoroutine(FadeIn(Play));
    }

    IEnumerator FadeIn(bool Play)
    {
        Fade.SetActive(true);
        imgFade.canvasRenderer.SetAlpha(1.0f);
        imgFade.CrossFadeAlpha(0, 1, false);
        yield return new WaitForSeconds(1f);
        Fade.SetActive(false);
        if (Play == true)
        {
            spawn.Resumer = true;
        }
    }
}
