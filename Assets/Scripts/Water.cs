using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerController>().isInWater = true;
        }
        if (other.tag == "PlayerHead")
        {
            other.GetComponent<PlayerController>().isUnderWater = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerController>().isInWater = false;
        }
        if (other.tag == "PlayerHead")
        {
            other.GetComponent<PlayerController>().isUnderWater = false;
        }
    }
}
