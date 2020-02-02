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

    private ItenInHandScript itemInHandHUD;
    public GameObject waterThrown;
    public bool isInWater;
    public bool isUnderWater;
    private GameObject water;

    public AudioClip piedBois;
    public AudioClip piedEau;
    public AudioClip repairTrou;
    public AudioClip moveEchelle;

    private bool isOnWaterHole = false;
    private GameObject waterHole;

    public string itemInHand;
    private Vector3 posToTP;

    //ActionMap Player
    public void OnAction(InputValue value)
    {
        if (isOnEchelle)
        {
            //GetComponent<PlayerInput>().SwitchCurrentActionMap("Ladder");
            //rb.useGravity = false;
            //animator.SetBool("Ladder",true);
            //switch entre actionmap ladder et player
            rb.MovePosition(posToTP);
            isOnEchelle = false;
        }

        if (currentInteraction.name == "FullBucket")
        {
            GameObject waterFromBucket = Instantiate(waterThrown, transform.position, Quaternion.Euler(transform.eulerAngles));
            waterFromBucket.GetComponent<Rigidbody>().AddForce(transform.forward * 5f, ForceMode.Impulse);
            currentInteraction.name = "EmptyBucket";
        }

        if (isInWater && currentInteraction.name == "EmptyBucket")
        {
            if(water.transform.position.y > 0)
            {
                water.transform.position -= new Vector3(0, 1, 0);
                currentInteraction.name = "FullBucket";

                if (water.transform.position.y < 0)
                {
                    water.transform.position = new Vector3(water.transform.position.x, 0, water.transform.position.z);
                }
            }
        }


        if (isOnWaterHole)
        {
            if(currentInteraction!=null && currentInteraction.name == "WoodPlank")
            {
                Destroy(waterHole);
                waterHole = null;
                currentInteraction.name = "None";
            }
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
        if (isOnEchelle)
        {
            GetComponent<PlayerInput>().SwitchCurrentActionMap("Player");
            animator.SetBool("Ladder",false);
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
        var value = inputValue.Get<float>();
        Debug.Log(currentInteraction.name);
        Vector3 rot = currentInteraction.gameObject.transform.rotation.eulerAngles;
        rot.y += (value * 3);
        currentInteraction.gameObject.transform.rotation = Quaternion.Euler(rot);
    }

    public void OnFireCanon(InputValue inputValue)
    {
        GameObject boulet = Resources.Load<GameObject>("Prefabs/FriendlyCanonBall");
        
        GameObject go = Instantiate(boulet, currentInteraction.transform.position + (currentInteraction.transform.forward * -2), Quaternion.Euler(currentInteraction.transform.rotation.eulerAngles + new Vector3(0, 180, 0)), null);
        
        currentInteraction.GetComponent<AudioSource>().Play();
        //TODO musique
        GetComponent<PlayerInput>().SwitchCurrentActionMap("Player");
        currentInteraction.name = "None";
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

        itemInHandHUD = GameObject.Find("ItemInHandIcon").GetComponent<ItenInHandScript>();
        Debug.Log(itemInHandHUD);
        water = GameObject.FindGameObjectWithTag("Water");

        Debug.Log(idJoueur);
        //switch
        switch (idJoueur)
        {
            case 1:
                //gameObject.GetComponentInChildren<SkinnedMeshRenderer>().material = Resources.Load<Material>("Materials/Red");
                gameObject.GetComponentInChildren<SkinnedMeshRenderer>().material = Resources.Load<Material>("Materials/MaterialPirate1");
                transform.position += new Vector3(1, 0, 0);
                //gameObject.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Materials/Red");
                break;
            case 2:
                transform.position += new Vector3(-1, 0, 0);
                gameObject.GetComponentInChildren<SkinnedMeshRenderer>().material = Resources.Load<Material>("Materials/MaterialPirate2");
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
        if(currentInteraction != null)
        {
            itemInHand = currentInteraction.name;
            itemInHandHUD.UpdateItemInHand(itemInHand);
        }

        animator.SetFloat("MoveVectorMagnitude", direction.magnitude);
        if (direction.magnitude > 0f)
        {
            
            if (GetComponent<PlayerInput>().currentActionMap.name == "Player")
            {
                rb.MovePosition(rb.transform.position + direction * Time.deltaTime * speed);
                transform.LookAt(rb.transform.position + direction, new Vector3(0, 1, 0));
            }
            else if (GetComponent<PlayerInput>().currentActionMap.name == "Ladder")
            {
                rb.MovePosition(rb.transform.position + direction * Time.deltaTime * speed);
            }
            
        }        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Echelle")
        {
            isOnEchelle = true;
            posToTP = other.gameObject.GetComponent<EchelleTP>().tpPos;
        }

        if (other.tag == "Canon")
        {
            Debug.Log(currentInteraction.name);
            if (currentInteraction.name == "CanonBall")
            {
                Destroy(currentInteraction);
                currentInteraction = other.gameObject;
                GetComponent<PlayerInput>().SwitchCurrentActionMap("Canon");
            }            
        }

        if (other.tag == "Bucket")
        {
            if(currentInteraction == null || currentInteraction.name != "FullBucket")
            {
                currentInteraction = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                currentInteraction.SetActive(false);
                currentInteraction.name = "EmptyBucket";
                Debug.Log(currentInteraction);
            }
        }

        if (other.tag == "WaterBarrel" && currentInteraction != null && currentInteraction.name == "EmptyBucket")
        {
            currentInteraction = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            currentInteraction.SetActive(false);
            currentInteraction.name = "FullBucket";
            Debug.Log(currentInteraction);
        }

        if (other.tag == "WoodBarrel")
        {
            currentInteraction = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            currentInteraction.SetActive(false);
            currentInteraction.name = "WoodPlank";
            Debug.Log(currentInteraction);
        }

        if (other.tag == "BouletBarrel")
        {
            currentInteraction = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            currentInteraction.SetActive(false);
            currentInteraction.name = "CanonBall";
            Debug.Log(currentInteraction);
        }

        if (other.tag == "WaterHole")
        {
            isOnWaterHole=true;
            waterHole = other.gameObject;
        }

        Debug.Log(other.tag);
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Echelle")
        {
            //isOnEchelle = false;
            //if (GetComponent<PlayerInput>().currentActionMap.name == "Ladder")
            //{
            //    GetComponent<PlayerInput>().SwitchCurrentActionMap("Player");
            //}
        }

        if (other.tag == "WaterHole")
        {
            isOnWaterHole = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        
    }
}
