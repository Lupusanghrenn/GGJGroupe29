using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public void OnAction(InputValue value)
    {
        Debug.Log(value.Get()); 
    }

    public void OnMove(InputValue value)
    {
        Debug.Log(value.Get<Vector2>());
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}
