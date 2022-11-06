using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AlienImmigration;
using UnityEngine.Rendering;

public class AudioManager : MonoBehaviour
{
    #region Fields

    [SerializeField] private AudioSource menuMusic;
    [SerializeField] private AudioSource boothMusic;
    [SerializeField, Range(0, 1000)] private float musicVolume;

    #endregion

    #region Public Functions

    public void PlaySFX(AudioSource audioSource)
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    #endregion

    #region

    private IEnumerator FadeInMusic(AudioSource audioSource)
    {
        while (audioSource.volume < musicVolume)
        {
            yield return new WaitForSeconds(0.05f);
            audioSource.volume++;
        }
    }

    private IEnumerator FadeOutMusic(AudioSource audioSource)
    {
        while (audioSource.volume > 0)
        {
            yield return new WaitForSeconds(0.05f);
            audioSource.volume--;
        }
    }

    public IEnumerator PlayMenuMusic()
    {
        if (boothMusic.isPlaying)
        {
            yield return StartCoroutine(FadeOutMusic(boothMusic));
            boothMusic.Stop();
        }

        if (!menuMusic.isPlaying)
        {
            menuMusic.volume = 0;
            menuMusic.Play();

            StartCoroutine(FadeInMusic(menuMusic));
        }
    }

    public IEnumerator PlayBoothMusic()
    {
        if (menuMusic.isPlaying)
        {
            yield return StartCoroutine (FadeOutMusic(menuMusic));
            menuMusic.Stop();
        }

        if (!boothMusic.isPlaying)
        {
            boothMusic.volume = 0;
            boothMusic.Play();

            StartCoroutine (FadeInMusic(boothMusic));
        }
    }

    #endregion

    #region Private Functions

    #endregion


}
