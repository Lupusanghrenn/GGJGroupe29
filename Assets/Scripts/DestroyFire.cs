using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFire : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Fire")
        {
            Destroy(other.gameObject);
        }
    }
}
