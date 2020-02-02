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
            if (other.gameObject.name.Contains("Fire"))
            {
                Destroy(other.gameObject);
            }
            else
            {
                Destroy(other.transform.parent.gameObject);
            }
        }
    }
}
