using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{
    public float healAmount;
    public bool interactBaril = false;

    public void OnAction(InputValue value)
    {
        if (interactBaril)
        {
            GetComponent<PlayerHealthManager>().Heal(healAmount);
        }
    }
}
