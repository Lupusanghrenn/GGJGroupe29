using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public GameObject waterFountain;

    private GameObject water;

    void Start()
    {
        water = GameObject.FindGameObjectWithTag("Water");

        Instantiate(waterFountain, this.transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)), this.transform);
    }

    void Update()
    {
        water.transform.position += new Vector3(0, 0.15f * Time.deltaTime, 0);
    }
}
