using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovingAudio : MonoBehaviour
{
    public AudioSource src;
    public AudioClip rocketMoveSound;

    public void RocketMoving() {
        src.clip = rocketMoveSound;
        src.Play();
    }//rocket launch sound
}
