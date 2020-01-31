using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public List<Transform> spawns;
    public GameObject firePrefab;

    public int dot;
    public float timeToPropagate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Propagate", timeToPropagate, timeToPropagate);
    }

    public void Propagate()
    {
        int rdm;
        //check pour savoir si y'a déjà un feu
        bool fireDetected = false;
        do
        {
            rdm = Random.Range(0, spawns.Count);
            Collider[] colliders = Physics.OverlapSphere(transform.position + spawns[rdm].position, 0.2f, 8);
            if (colliders.Length > 0)
            {
                Debug.Log("sdfdsfds");
                fireDetected = true;
            }
        } while (fireDetected);

        GameObject spawnedFire = Instantiate(firePrefab, spawns[rdm].position, Quaternion.identity);
    }
}
