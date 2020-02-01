using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TonnEau : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(other.GetComponent<PlayerController>().hasBucket)
            {
                other.GetComponent<PlayerController>().bucketIsFull = true;
            }
           
        }
    }
}
