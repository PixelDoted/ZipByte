using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AudioDownloader : MonoBehaviour
{
    public AudioClip[] Audios;
    public GameObject sourceObj;
    private AudioSource source;

    void Start()
    {
        source = sourceObj.GetComponent<AudioSource>();
    }

    public void LoadAudio(int ID)
    {
        if (ID != 32767)
        {
            sourceObj.SetActive(true);
            source.clip = Audios[ID];
        }
        else
        {
            sourceObj.SetActive(false);
        }
    }

}
