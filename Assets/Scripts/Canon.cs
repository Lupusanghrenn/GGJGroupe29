using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && other.GetComponent<PlayerInteract>().interacting == false)
        {
            other.GetComponent<PlayerInteract>().interacting = true;
            other.GetComponent<PlayerInteract>().interactCanon = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && other.GetComponent<PlayerInteract>().interacting == false)
        {
            other.GetComponent<PlayerInteract>().interacting = true;
            other.GetComponent<PlayerInteract>().interactCanon = false;
        }
    }
}