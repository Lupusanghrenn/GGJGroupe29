using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterThrownScript : MonoBehaviour
{
    public SoundPlayer soundPlayer;
    public AudioClip feuEteint;

    private void Start()
    {
        Destroy(this.gameObject, 1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fire")
        {
            if (other.gameObject.name.Contains("Fire"))
            {
                Destroy(other.gameObject);
            }
            else
            {
                Destroy(other.transform.parent.gameObject);
            }
            SoundPlayer sp = Instantiate(soundPlayer, other.gameObject.transform.position, Quaternion.identity);
            sp.PlaySound(feuEteint, 1f);
        }

    }
}
