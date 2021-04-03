using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Video;
using TMPro;

public class MusicHandler : MonoBehaviour
{

    public TMP_InputField MusicField;
    public AudioClip clip;
    public AudioSource source;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void downloadMusic()
    {
        StartCoroutine(getAudioClip());
    }

    public void Play()
    {
        source.gameObject.SetActive(true);
        source.Play();
    }

    public void Stop()
    {
        source.Stop();
        source.gameObject.SetActive(false);
    }

    public void getAudioClipfromVideo()
    {
        VideoPlayer vid = new VideoPlayer();
        vid.url = MusicField.text;
        vid.audioOutputMode = VideoAudioOutputMode.AudioSource;
        vid.SetTargetAudioSource(0, source);
        Play();
    }

    IEnumerator getAudioClip()
    {
        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(MusicField.text, AudioType.MPEG))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success && www.result != UnityWebRequest.Result.InProgress)
            {
                Debug.Log(www.error);
                yield break;
            } else {
                source.clip = DownloadHandlerAudioClip.GetContent(www);
                Play();
            }
        }
    }
}
