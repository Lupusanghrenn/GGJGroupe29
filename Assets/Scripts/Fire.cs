﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public List<Transform> spawns;
    public GameObject firePrefab;
    public LayerMask layer;
    public bool parent;

    private GameObject boat;

    public float dot;
    public float timeToPropagate;

    // Start is called before the first frame update
    void Start()
    {
        boat = GameObject.FindGameObjectWithTag("Boat");
        Invoke("Propagate", timeToPropagate);
    }

    private void Update()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().currentLife -= dot * Time.deltaTime;
    }

    public void Propagate()
    {
        if (spawns.Count > 0)
        {
            int rdm = Random.Range(0, spawns.Count);
            GameObject spawnedFire = Instantiate(firePrefab, spawns[rdm].position, Quaternion.identity, boat.transform);
            spawnedFire.transform.Find("Canvas").GetChild(0).GetComponent<UIFloatingText>().displayWarning = false;
            spawnedFire.transform.localScale = transform.localScale;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerHealthManager>().TakeDamage(dot);
        }
    }
}
