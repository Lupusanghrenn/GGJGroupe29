using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterThrownScript : MonoBehaviour
{
    private void Start()
    {
        Destroy(this.gameObject, 1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fire")
        {
            Destroy(other.gameObject);
        }
    }
}
