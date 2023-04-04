using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioScript : MonoBehaviour
{
    public MontyHallGame round;
    public AudioSource audioSource;
    public AudioClip clip;
    public AudioClip clip2;
    public AudioClip winSwap;
    public AudioClip winStay;
    public AudioClip loseStay;
    public AudioClip loseSwap;
    public const string audioName = "Introduction Audio.mp3";
    private bool switchedOn = true;
    private bool endAudio = true;



    public void PlayAudio()
    {
        if (round.roundNumber == 1) 
        {
            GetComponent<AudioSource>().clip = clip;
            GetComponent<AudioSource>().Play();
        }

        
    }

    public void PlayAudio2()
    {
        if (switchedOn == true)
        {
            GetComponent<AudioSource>().clip = clip2;
            GetComponent<AudioSource>().Play();
            switchedOn = false;
        }


    } 
    
    public void WinSwap()
    {
        if(endAudio== true)
        {
            GetComponent<AudioSource>().clip = winSwap;
            GetComponent<AudioSource>().Play();
            endAudio = false;
        }
    }
    
    public void WinStay()
    {
        if (endAudio == true)
        {
            GetComponent<AudioSource>().clip = winStay;
            GetComponent<AudioSource>().Play();
            endAudio = false;
        }
    }

    public void LoseStay()
    {
        if (endAudio == true)
        {
            GetComponent<AudioSource>().clip = loseStay;
            GetComponent<AudioSource>().Play();
            endAudio = false;
        }
    }

    public void LoseSwap()
    {
        if (endAudio == true)
        {
            GetComponent<AudioSource>().clip = loseSwap;
            GetComponent<AudioSource>().Play();
            endAudio = false;
        }
    }
}
