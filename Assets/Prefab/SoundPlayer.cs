using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public void PlaySound(AudioClip audio)
    {
        GetComponent<AudioSource>().PlayOneShot(audio);
    }
}
