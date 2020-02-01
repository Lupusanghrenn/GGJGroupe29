using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public List<Transform> spawns;
    public GameObject firePrefab;
    public LayerMask layer;

    public float dot;
    public float timeToPropagate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Propagate", timeToPropagate, timeToPropagate);
    }

    private void Update()
    {
        //GameObject.Find("GameManager").GetComponent<GameManager>().life -= dot;
    }

    public void Propagate()
    {
        int rdm;
        bool ok = false;
        while(!ok && spawns.Count > 0)
        {
            rdm = Random.Range(0, spawns.Count);
            Collider[] colliders = Physics.OverlapSphere(transform.position + spawns[rdm].position, 0.005f, layer);
            ok = true;
            if (colliders.Length > 0)
            {
                spawns.RemoveAt(rdm);
            }
            else
            {
                ok = true;
                GameObject spawnedFire = Instantiate(firePrefab, spawns[rdm].position, Quaternion.identity);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerHealthManager>().TakeDamage(0.5f);
        }
    }
}
