using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public GameObject waterFountain;

    void Start()
    {
        Instantiate(waterFountain, this.transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)), this.transform);
    }

    void Update()
    {
        
    }
}
