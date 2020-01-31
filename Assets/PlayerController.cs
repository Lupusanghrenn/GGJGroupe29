using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    public void OnAction(InputValue value)
    {
        Debug.Log(value.Get()); 
    }

    public void OnMove(InputValue inputValue)
    {
        //Debug.Log(value.Get<Vector2>());
        direction = inputValue.Get<Vector2>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        var allGamepad = Gamepad.all;
        foreach(var gamepad in allGamepad){
            Debug.Log(gamepad);
        }
        //Debug.Log(allGamepad);
    }

    // Update is called once per frame
    void Update()
    {
        if (direction.magnitude > 0f)
        {
            gameObject.transform.position += new Vector3(direction.x, 0, direction.y) * Time.deltaTime * speed;
        }
        
    }
}
