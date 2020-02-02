using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderwaterDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        transform.parent.GetComponent<PlayerController>().isUnderWater = true;
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent.GetComponent<PlayerController>().isUnderWater = false;
    }
}
