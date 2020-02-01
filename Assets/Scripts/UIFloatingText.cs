using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFloatingText : MonoBehaviour
{
    public float speed;
    public float timeToWait;
    private float currentTime = 0;
    private float timeActivate = 0;
    bool sens = false;


    private void Start()
    {
        gameObject.GetComponent<Image>().enabled = false;
    }

    void Update()
    {
        timeActivate += Time.deltaTime;
        if (timeActivate >= 10)
        {
            gameObject.GetComponent<Image>().enabled = true;
            currentTime += Time.deltaTime;
            if (currentTime >= timeToWait)
            {
                sens = !sens;
                currentTime = 0;
            }

            if (sens)
            {
                transform.position += new Vector3(0, -speed, 0);
            }
            else
            {
                transform.position += new Vector3(0, speed, 0);
            }
        }
    }
}
