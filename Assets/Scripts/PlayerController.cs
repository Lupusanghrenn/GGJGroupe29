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
    public int idJoueur;
    private bool isOnEchelle = false;
    private GameObject currentInteraction;


    //ActionMap Player
    public void OnAction(InputValue value)
    {
        Debug.Log("Action");

        if (isOnEchelle)
        {
            GetComponent<PlayerInput>().SwitchCurrentActionMap("Ladder");
            rb.useGravity = false;
            //switch entre actionmap ladder et player

        }
    }

    public void OnRelease(InputValue value)
    {
        Debug.Log("Release");
    }

    public void OnMove(InputValue inputValue)
    {
        //Debug.Log(value.Get<Vector2>());
        var value = inputValue.Get<Vector2>();
        direction = new Vector3(value.x, 0, value.y);
    }

    //ActionMap Ladder
    public void OnActionLadder(InputValue value)
    {
        Debug.Log("Action");

        if (isOnEchelle)
        {
            GetComponent<PlayerInput>().SwitchCurrentActionMap("Player");
            rb.useGravity = true;

        }
    }

    public void OnMoveLadder(InputValue inputValue)
    {
        var value = inputValue.Get<float>();
        direction = new Vector3(0,value,0);
    }

    //ActionMap Canon
    public void OnMoveCanon(InputValue inputValue)
    {
        Debug.Log("MoveCanon");
        var value = inputValue.Get<float>();
        Debug.Log(value);
    }

    public void OnFireCanon(InputValue inputValue)
    {
        Debug.Log("OnFireCannon");
        GameObject boulet = Resources.Load<GameObject>("Prefabs/FriendlyCanonBall");
        //Instantiate(boulet, transform.position + (transform.forward * 4), Quaternion.Euler(0, 0, 0), null);
        //Instantiate(boulet, currentInteraction.transform.position + (currentInteraction.transform.forward * 4), Quaternion.Euler(0, 0, 0), null);
        //Destroy(FindObjectOfType<EnemyShip>().gameObject);
        currentInteraction.GetComponent<AudioSource>().Play();
        //TODO musique
        GetComponent<PlayerInput>().SwitchCurrentActionMap("Player");
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

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Echelle")
        {
            isOnEchelle = true;

        }

        if (other.tag == "Canon")
        {
            currentInteraction = other.gameObject;
            GetComponent<PlayerInput>().SwitchCurrentActionMap("Canon");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Echelle")
        {
            isOnEchelle = false;

        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        
    }
}
