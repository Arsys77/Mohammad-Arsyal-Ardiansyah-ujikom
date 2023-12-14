using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public SoundSource[] soundsMusik; 
    public SoundSource[] soundsEfek;
    public AudioSource SourceMusik;
    public AudioSource SourceEfek;

    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayBG("MainScreen_BGM");
    }


    public void PlayBG(string namaAudio)
    {
        SoundSource audioManager = Array.Find(soundsMusik, x => x.namaAudio == namaAudio);

        if (audioManager == null)
        {
            Debug.Log("No Sound Founded: " + namaAudio);
        }
        else
        {
            SourceMusik.clip = audioManager.clip;
            SourceMusik.Play();
        }
    }

    public void StopBG(string namaAudio)
    {
        SoundSource audioManager = Array.Find(soundsMusik, x => x.namaAudio == namaAudio);

        if (audioManager == null)
        {
            Debug.Log("No Sound Founded: " + namaAudio);
        }
        else
        {
            SourceMusik.clip = audioManager.clip;
            SourceMusik.Stop();
        }
    }

    public void PlayEfek(string namaAudio)
    {
        SoundSource audioManager = Array.Find(soundsEfek, x => x.namaAudio == namaAudio);

        if (audioManager == null)
        {
            Debug.Log("No Sound Founded: " + namaAudio);
        }
        else
        {
            SourceEfek.PlayOneShot(audioManager.clip);
        }
    }

}
