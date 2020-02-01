using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBaril : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerInteract>().interactBaril = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerInteract>().interactBaril = false;
        }
    }
}
