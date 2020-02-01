using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector3 direction;
    private GameManager gameManager;
    private Animator animator;
    private Rigidbody rb;
    private bool isInEchelle;
    public int idJoueur;
    public void OnAction(InputValue value)
    {
        Debug.Log("Action"); 
    }

    public void OnMove(InputValue inputValue)
    {
        //Debug.Log(value.Get<Vector2>());
        var value = inputValue.Get<Vector2>();
        direction = new Vector3(value.x, 0, value.y);
    }

    public void OnMoveLadder(InputValue inputValue)
    {
        Debug.Log("MoveLadder");
        var value = inputValue.Get<float>();
        direction = new Vector3(0,value,0);
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        transform.position = gameManager.transform.position;
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        gameManager.nbJoueur++;
        idJoueur = gameManager.nbJoueur;
        gameObject.name = "Player" + idJoueur;
        isInEchelle = false;

        Debug.Log(idJoueur);
        //switch
        switch (idJoueur)
        {
            case 1:
                gameObject.GetComponentInChildren<SkinnedMeshRenderer>().material = Resources.Load<Material>("Materials/Red");
                transform.position += new Vector3(1, 0, 0);
                //gameObject.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Materials/Red");
                break;
            case 2:
                transform.position += new Vector3(-1, 0, 0);
                rb.
                gameObject.GetComponentInChildren<SkinnedMeshRenderer>().material = Resources.Load<Material>("Materials/Blue");
                //gameObject.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Materials/Blue");
                break;
            default:
                Debug.LogError("Plus de 2 joueurs");
                break;
        }

        //GetComponent<PlayerInput>().SwitchCurrentActionMap("Ladder");
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("MoveVectorMagnitude", direction.magnitude);
        if (direction.magnitude > 0f)
        {
            //gameObject.transform.position +=  * Time.deltaTime * speed;
            rb.MovePosition(rb.transform.position + direction * Time.deltaTime * speed);
            //rigidbody.MoveRotation(Quaternion.Euler(direction));
            //rigidbody.MoveRotation(Quaternion.AngleAxis(45, new Vector3(0, 1, 0)));
            if (GetComponent<PlayerInput>().currentActionMap.name == "Player")
            {
                transform.LookAt(rb.transform.position + direction, new Vector3(0, 1, 0));
            }
            
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "Echelle")
        {
            if (!isInEchelle)
            {
                GetComponent<PlayerInput>().SwitchCurrentActionMap("Ladder");
                isInEchelle = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Echelle")
        {
            if (isInEchelle)
            {
                GetComponent<PlayerInput>().SwitchCurrentActionMap("Player");
                isInEchelle = false;
            }
            else
            {
                GetComponent<PlayerInput>().SwitchCurrentActionMap("Ladder");
                isInEchelle = true;
            }
        }
    }
}
