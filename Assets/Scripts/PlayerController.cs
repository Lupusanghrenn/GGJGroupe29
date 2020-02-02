﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed;
    public float waterSpeed;
    public float underWaterSpeed;

    public float speed;
    private Vector3 direction;
    private GameManager gameManager;
    private Animator animator;
    private Rigidbody rb;
    public int idJoueur;
    public bool isOnEchelle = false;
    private GameObject currentInteraction;

    private ItenInHandScript itemInHandHUD;
    public GameObject waterThrown;
    public bool isInWater;
    public bool isUnderWater;
    private GameObject water;

    private AudioSource audio;

    public AudioClip piedBois;
    public AudioClip piedEau;

    public AudioClip prendreItem;
    public AudioClip repairTrou;
    public AudioClip jeterEau;
    public AudioClip recupererEau;
    public AudioClip boireRhum;
    public AudioClip drunk;


    private bool isOnWaterHole = false;
    private GameObject waterHole;

    public string itemInHand;
    public Vector3 posToTP;

    public bool isInCale;
    public bool isAtEcoutille;
    public bool isDrunk=false;

    public float drunkTime = 3;

    public Canvas canvasPause;

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

        else if (currentInteraction != null && currentInteraction.name == "FullBucket")
        {
            GameObject waterFromBucket = Instantiate(waterThrown, transform.position, Quaternion.Euler(transform.eulerAngles));
            waterFromBucket.GetComponent<Rigidbody>().AddForce(transform.forward * 5f, ForceMode.Impulse);
            currentInteraction.name = "EmptyBucket";

            PlayClip(jeterEau);

            if((isInCale && !isAtEcoutille) || (isAtEcoutille && transform.right.z < 0.5f))
            {
                water.transform.position += new Vector3(0, 1, 0);
            }
        }

        else if (isInWater && currentInteraction.name == "EmptyBucket")
        {
            if(water.transform.position.y > 0)
            {
                water.transform.position -= new Vector3(0, 1, 0);
                currentInteraction.name = "FullBucket";
                PlayClip(recupererEau);

                if (water.transform.position.y < 0)
                {
                    water.transform.position = new Vector3(water.transform.position.x, 0, water.transform.position.z);
                }
            }
        }


        else if (isOnWaterHole)
        {
            if(currentInteraction!=null && currentInteraction.name == "WoodPlank")
            {
                Destroy(waterHole);
                waterHole = null;
                currentInteraction.name = "None";
                PlayClip(repairTrou);
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
        if (isDrunk)
        {
            value.x = -value.x;
            //value.y = -value.y;
        }
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

    public void OnPause(InputValue value)
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
        canvasPause.enabled = !canvasPause.enabled;

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
        currentInteraction=null;
    }

    // Start is called before the first frame update
    void Start()
    {
        canvasPause.enabled = false;
        audio = GetComponent<AudioSource>();
        speed = maxSpeed;
        gameManager = FindObjectOfType<GameManager>();
        transform.position = gameManager.transform.position;
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        gameManager.nbJoueur++;
        idJoueur = gameManager.nbJoueur;
        gameObject.name = "Player" + idJoueur;

        itemInHandHUD = GetComponentInChildren<ItenInHandScript>();
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
        if(!isInCale && transform.position.y >= 8.2f)
        {
            transform.position = new Vector3(transform.position.x, 8.2f, transform.position.z);
        }

        if(isInCale && transform.position.y >= 6.25f)
        {
            transform.position = new Vector3(transform.position.x, 6.25f, transform.position.z);
        }

        if (currentInteraction != null)
        {
            itemInHand = currentInteraction.name;
            itemInHandHUD.UpdateItemInHand(itemInHand);
        }

        if(isUnderWater)
        {
            GetComponent<PlayerHealthManager>().TakeDamage(5 * Time.deltaTime);
            speed = underWaterSpeed;
        } 
        else if(isInWater && !isUnderWater)
        {
            speed = waterSpeed;
        }
        else
        {
            speed = maxSpeed;
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

    private void PlayClip(AudioClip clip)
    {
        audio.clip = clip;
        audio.Play();
    }

    private void RemoveDrunkingEffect()
    {
        isDrunk = false;
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
            if (currentInteraction.name == "CanonBall")
            {
                Destroy(currentInteraction);
                currentInteraction = other.gameObject;
                GetComponent<PlayerInput>().SwitchCurrentActionMap("Canon");
                PlayClip(prendreItem);
            }            
        }

        if (other.tag == "Bucket")
        {
            if(currentInteraction == null || currentInteraction.name != "FullBucket")
            {
                currentInteraction = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                currentInteraction.SetActive(false);
                currentInteraction.name = "EmptyBucket";
                PlayClip(prendreItem);

                Debug.Log(currentInteraction);
            }
        }

        if (other.tag == "WaterBarrel" && currentInteraction != null && currentInteraction.name == "EmptyBucket")
        {
            currentInteraction = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            currentInteraction.SetActive(false);
            currentInteraction.name = "FullBucket";
            PlayClip(recupererEau);

            Debug.Log(currentInteraction);
        }

        if (other.tag == "WoodBarrel")
        {
            currentInteraction = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            currentInteraction.SetActive(false);
            currentInteraction.name = "WoodPlank";
            PlayClip(prendreItem);
            Debug.Log(currentInteraction);
        }

        if (other.tag == "BouletBarrel")
        {
            currentInteraction = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            currentInteraction.SetActive(false);
            currentInteraction.name = "CanonBall";
            PlayClip(prendreItem);

            Debug.Log(currentInteraction);
        }

        if (other.tag == "RhumerieColliderDetection")
        {
            CancelInvoke();
            GetComponent<PlayerHealthManager>().Heal(GetComponent<PlayerHealthManager>().maxHealth / 2);
            isDrunk = true;
            Invoke("RemoveDrunkingEffect", drunkTime);
        }

        if (other.tag == "CaleColliderDetection")
        {
            isInCale = true;
        }
        if (other.tag == "EcoutilleColliderDetection")
        {
            isAtEcoutille = true;
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
            isOnEchelle = false;
        }

        if (other.tag == "WaterHole")
        {
            isOnWaterHole = false;
        }

        if (other.tag == "EcoutilleColliderDetection")
        {
            isAtEcoutille = false;
        }

        if (other.tag == "CaleColliderDetection")
        {
            isInCale = false;
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        
    }
}
