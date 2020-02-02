using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRhumerie : MonoBehaviour
{

    public float drunkTime = 3;
    private PlayerController playerController;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            CancelInvoke();
            other.GetComponent<PlayerHealthManager>().Heal(other.GetComponent<PlayerHealthManager>().maxHealth/2);
            playerController = other.GetComponent<PlayerController>();
            playerController.isDrunk = true;
            Invoke("RemoveDrunkingEffect", drunkTime);
        }
    }

    private void RemoveDrunkingEffect()
    {
        playerController.isDrunk = false;

    }
}
