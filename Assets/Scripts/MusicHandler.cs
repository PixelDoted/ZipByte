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
        source.clip = clip;
        Play();
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

            if (www.isHttpError || www.isNetworkError)
            {
                Debug.Log(www.error);
                yield break;
            } else {
                clip = DownloadHandlerAudioClip.GetContent(www);
            }
        }
    }
}
