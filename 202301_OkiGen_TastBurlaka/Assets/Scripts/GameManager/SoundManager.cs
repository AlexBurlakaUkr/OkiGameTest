using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public WinTheGame winTheGame;
    public AudioSource wrongFruit;
    public AudioSource correctFruit;
    public AudioSource fonMusic;
    public List<AudioSource> audioForWinDance = new List<AudioSource>();
    private int numberOfaudioClip;

    private void Awake()
    {
        Instance= this;
    }
    private void Start()
    {
        numberOfaudioClip = winTheGame.indexNumber;
    }
    public void PlayWrongClip()
    {
        wrongFruit.Play();
    }

    public void PlayCorrectClip()
    {
        correctFruit.Play();
    }
    public void StopFonMusic()
    {
        fonMusic.Pause();
    }
    public void PlayAudioForWinDance()
    {
        audioForWinDance[numberOfaudioClip].Play();
    }
}
