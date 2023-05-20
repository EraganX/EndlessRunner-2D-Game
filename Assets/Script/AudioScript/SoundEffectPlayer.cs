using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip click;

    public void ClickButton() {
        src.clip = click;
        src.Play();
    } // button clicked sound
}
