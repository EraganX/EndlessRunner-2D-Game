using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlaySounds : MonoBehaviour
{
    public AudioSource src;
    public AudioClip Jump, Explotion;

    public void JumpSound()
    {
        src.clip = Jump;
        src.Play();
    }

    public void BoomSound()
    {
        src.clip = Explotion;
        src.Play();
    }
}

