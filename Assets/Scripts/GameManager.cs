﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float maxLife; //vie du bateau

    public GameObject water;

    public float currentLife;
    private GameObject boat;
    public List<GameObject> eventsProbable;
    public List<GameObject> eventsPeuProbable;
    public BoxCollider spawnFire;
    public float BaseTimeToWait;
    public float baseTimeMin;
    public float baseTimeMax;
    public float gameTime;
    public Text timerText;
    public Image lifeFill;
    public Canvas canvasLoss;
    public Canvas canvasWin;
    public AudioClip sonWin;
    public AudioClip sonLose;
    private bool done = false;

    private float timeToWait;
    private float timeElapsed;
    private float gameTimeLeft;
    private int nbSpawn = 0;

    public int nbJoueur = 0;
    // Start is called before the first frame update
    void Start()
    {
        water = GameObject.Find("WaterPrefab");
        canvasWin.gameObject.SetActive(false);
        canvasLoss.gameObject.SetActive(false);
        currentLife = maxLife;
        gameTimeLeft = gameTime;
        boat = GameObject.FindGameObjectWithTag("Boat");
        timeToWait = Random.Range(baseTimeMin, baseTimeMax);
    }

    // Update is called once per frame
    void Update()
    {

        currentLife -= water.transform.position.y * Time.deltaTime * 1.5f;
        //Debug.Log(life);
        if (gameTimeLeft <= 0)
        {
            gameTimeLeft = 0;
        }
        else
        {
            gameTimeLeft -= Time.deltaTime;
        }

        int min = Mathf.CeilToInt(gameTimeLeft / 60 - 1);
        if (min <= 0)
        {
            min = 0;
        }
        int sec = Mathf.RoundToInt(gameTimeLeft % 60 - 1);
        if (sec <= 0)
        {
            sec = 0;
        }

        if (gameTimeLeft <= 0)
        {
            if (!done)
            {

                Win();
                done = true;
            }
        }


        string str = min.ToString() + " : " + sec.ToString();
        timerText.text = str;
        if (gameTimeLeft >= gameTime)
        {
            //La game se termine
        }

        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeToWait)
        {
            //event
            nbSpawn++;

            int rdmEventPool = Random.Range(0, 101);
            if (rdmEventPool < 50) //événement probable
            {
                int rdmEvent = Random.Range(0, eventsProbable.Count);

                if(eventsProbable[rdmEvent].name == "Tanguage")
                {
                    Debug.Log("EVENT PROBABLE: Tanguage");
                    Instantiate(eventsProbable[rdmEvent], Vector3.zero, Quaternion.identity);
                }
                if (eventsProbable[rdmEvent].name == "Fire")
                {
                    Debug.Log("EVENT PROBABLE: Fire");
                    //float rdmX = Random.Range(-spawnFire.size.x / 2, spawnFire.size.x / 2);
                    //float rdmZ = Random.Range(-spawnFire.size.z / 2, spawnFire.size.z / 2);

                    float rdmX = Random.Range(spawnFire.bounds.min.x, spawnFire.bounds.max.x);
                    float rdmZ = Random.Range(spawnFire.bounds.min.z, spawnFire.bounds.max.z);
                    Instantiate(eventsProbable[rdmEvent], new Vector3(rdmX, spawnFire.transform.position.y + 1.5f, rdmZ), Quaternion.identity, boat.transform);
                }
            }
            else //événement peu probable
            {
                int rdmEvent = Random.Range(0, eventsPeuProbable.Count);

                if (eventsPeuProbable[rdmEvent].name == "ObjetLourd")
                {
                    Debug.Log("EVENT PEU PROBABLE: ObjetLourd");
                    Instantiate(eventsPeuProbable[rdmEvent], Vector3.zero, Quaternion.identity);
                }
                else if (eventsPeuProbable[rdmEvent].name == "BateauPirate")
                {
                    Debug.Log("EVENT PEU PROBABLE: Bateau Pirate");
                    Instantiate(eventsPeuProbable[rdmEvent], Vector3.zero, Quaternion.identity);
                }
                else if (eventsPeuProbable[rdmEvent].name == "Hole")
                {
                    Debug.Log("EVENT PEU PROBABLE: Hole");
                    Instantiate(eventsPeuProbable[rdmEvent], Vector3.zero, Quaternion.identity);
                }
            }

            if(baseTimeMax >= 10)
            {
                baseTimeMax = baseTimeMax - (nbSpawn * 1.0f);
            }
            timeToWait = Random.Range(baseTimeMin, baseTimeMax);
            timeElapsed = 0;
        }

        if (currentLife <= 0)
        {
            if (!done)
            {
                Lose();
                done = true;
            }
        }
        //update de l'affichage de la vie
        //Debug.Log(currentLife + ", " + maxLife);
        lifeFill.fillAmount = currentLife / maxLife;
    }

    public void Win()
    {
        Time.timeScale = 0;
        canvasWin.gameObject.SetActive(true);
        GetComponent<AudioSource>().clip = null;
        GetComponent<AudioSource>().PlayOneShot(sonWin);
    }
    
    public void Lose()
    {
        Time.timeScale = 0;
        canvasLoss.gameObject.SetActive(true);
        GetComponent<AudioSource>().clip = null;
        GetComponent<AudioSource>().PlayOneShot(sonLose);
    }
}
