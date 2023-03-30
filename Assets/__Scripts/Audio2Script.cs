using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio2Script : MonoBehaviour
{
    public MontyHallGame round;
    public AudioSource audioSource;
    public AudioClip clip;
    public const string audioName = "Round2Audio.mp3";
    private bool audioOn = true;
    //private bool switchedOn = true;



    public void PlayAudio2()
    {
        //GetComponent<AudioSource>.enabled() = true;
        audioSource= GetComponent<AudioSource>();
        audioSource.enabled = true;
        if (round.playerChoice != 0)
            if(audioOn == true)
            {
                //GetComponent<AudioSource>().clip = clip;
                GetComponent<AudioSource>().Play();
                audioOn = false;
            }
           
        


    }

    // public void PlayAudio2()
    // {
    //        if (switchedOn = true)
    //    {
    //       GetComponent<AudioSource>().clip = clip;
    //       GetComponent<AudioSource>().Play();
    //        switchedOn= false;
    //    } 




}