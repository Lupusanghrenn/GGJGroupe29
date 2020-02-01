using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int life; //vie du bateau
    public List<GameObject> problems;
    public float BaseTimeToWait;

    private float timeToWait;
    private float timeElapsed;

    public int nbJoueur = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
    }
}
