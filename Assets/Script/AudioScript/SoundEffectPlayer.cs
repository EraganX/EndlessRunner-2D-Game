using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip click;
    //public AudioClip click, jump, boom;

    public void ClickButton() {
        src.clip = click;
        src.Play();
    }
}
