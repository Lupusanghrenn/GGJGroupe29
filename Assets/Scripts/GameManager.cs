using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float life; //vie du bateau

    public List<GameObject> eventsProbable;
    public List<GameObject> eventsPeuProbable;
    public BoxCollider spawnFire;
    public float BaseTimeToWait;
    public float baseTimeMin;
    public float baseTimeMax;

    private float timeToWait;
    private float timeElapsed;
    private int nbSpawn = 0;

    public int nbJoueur = 0;
    // Start is called before the first frame update
    void Start()
    {
        timeToWait = Random.Range(baseTimeMin, baseTimeMax);
    }

    // Update is called once per frame
    void Update()
    {       
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeToWait)
        {
            //event
            nbSpawn++;

            int rdmEventPool = Random.Range(0, 11);
            if (rdmEventPool < 7) //événement probable
            {
                int rdmEvent = Random.Range(0, eventsProbable.Count);

                if(eventsProbable[rdmEvent].name == "Tanguage")
                {
                    Debug.Log("EVENT PROBABLE: Tanguage");
                    Instantiate(eventsProbable[rdmEvent], Vector3.zero, Quaternion.identity);
                }
                if (eventsProbable[rdmEvent].name == "FireTest") // EDITED : Fire -> FireTest
                {
                    Debug.Log("EVENT PROBABLE: Fire");
                    //float rdmX = Random.Range(-spawnFire.size.x / 2, spawnFire.size.x / 2);
                    //float rdmZ = Random.Range(-spawnFire.size.z / 2, spawnFire.size.z / 2);
                    //Instantiate(eventsProbable[rdmEvent], new Vector3(rdmX, spawnFire.transform.position.y, rdmZ), Quaternion.identity);
                    Instantiate(eventsProbable[rdmEvent], Vector3.zero, Quaternion.identity);
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
    }
}
