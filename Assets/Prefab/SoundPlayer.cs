using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    private float time;
    public void PlaySound(AudioClip audio, float vol)
    {
        GetComponent<AudioSource>().volume = vol;
        GetComponent<AudioSource>().PlayOneShot(audio);
    }

    private void Update()
    {
        time += Time.deltaTime;
        if (time >= 10f)
        {
            Destroy(gameObject);
        }
    }
}
