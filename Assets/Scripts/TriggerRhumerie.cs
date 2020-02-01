using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRhumerie : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponent<PlayerHealthManager>().Heal(other.GetComponent<PlayerHealthManager>().maxHealth/2);
        }
    }
}
