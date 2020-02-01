using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFire : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.name);
        if (other.tag == "Fire")
        {
            transform.parent.GetComponent<Fire>().spawns.Remove(gameObject.transform);
            Destroy(gameObject);
        }
    }
}
