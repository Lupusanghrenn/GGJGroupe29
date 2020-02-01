using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public float maxHealth;
    public List<Transform> spawnPoints;
    public float timeToRespawn;
    private float currentHealth;
    public PlayerHealthBar healthBar;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(float amount)
    {
        //on prend es degats
        currentHealth -= amount;
        if (currentHealth <= 0) //le player est mort
        {
            currentHealth = 0;
            StartCoroutine(Die());
        }
        //on update la barre de vie
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
    }

    public IEnumerator Die()
    {
        //on desactive tout
        animator.SetBool("Dead", true);
        GetComponent<PlayerController>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;

        yield return new WaitForSeconds(timeToRespawn);

        int rdm = Random.Range(0, spawnPoints.Count);
        transform.position = spawnPoints[rdm].position;
        GetComponent<PlayerController>().enabled = true;
        GetComponent<CapsuleCollider>().enabled = true;
        animator.SetBool("Dead", false);
    }
}
