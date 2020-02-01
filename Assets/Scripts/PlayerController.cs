using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    private GameManager gameManager;
    public int idJoueur;
    public void OnAction(InputValue value)
    {
        Debug.Log("Action"); 
    }

    public void OnMove(InputValue inputValue)
    {
        //Debug.Log(value.Get<Vector2>());
        direction = inputValue.Get<Vector2>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        gameManager.nbJoueur++;
        idJoueur = gameManager.nbJoueur;
        gameObject.name = "Player" + idJoueur;

        Debug.Log(idJoueur);
        //switch
        switch (idJoueur)
        {
            case 1:
                gameObject.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Materials/Red");
                break;
            case 2:
                gameObject.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Materials/Blue");
                break;
            default:
                Debug.LogError("Plus de 2 joueurs");
                break;
        }
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
