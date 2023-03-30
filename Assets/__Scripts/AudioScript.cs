using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioScript : MonoBehaviour
{
    public MontyHallGame round;
    public AudioSource audioSource;
    public AudioClip clip;
    public const string audioName = "Introduction Audio.mp3";
    //private bool switchedOn = true;



    public void PlayAudio()
    {
        if (round.roundNumber == 1) 
        {
            GetComponent<AudioSource>().clip = clip;
            GetComponent<AudioSource>().Play();
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
