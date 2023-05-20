using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlaySounds : MonoBehaviour
{
    public AudioSource src;             //Audio Scorce
    public AudioClip Jump, Explotion;   //Audio clip 

    public void JumpSound()
    {
        src.clip = Jump;
        src.Play();
    } // player Jump Sound

    public void BoomSound()
    {
        src.clip = Explotion;
        src.Play();
    } // Rocket Explotion Sound
}

