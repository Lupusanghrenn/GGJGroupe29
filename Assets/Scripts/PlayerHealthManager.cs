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
    public RespawnCircle respawnCircle;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
        respawnCircle.gameObject.SetActive(false);
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

    public void Heal(float value)
    {
        currentHealth += value;
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
    }

    public IEnumerator Die()
    {
        //on desactive tout
        Debug.Log("Player dead");
        animator.SetBool("Dead", true);
        GetComponent<PlayerController>().enabled = false;
        respawnCircle.timeTimeToRespawn = timeToRespawn;
        respawnCircle.gameObject.SetActive(true);

        yield return new WaitForSeconds(timeToRespawn);


        respawnCircle.Reset();
        respawnCircle.gameObject.SetActive(false);
        int rdm = Random.Range(0, spawnPoints.Count);
        currentHealth = maxHealth;
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
        GetComponent<PlayerController>().enabled = true;
        transform.position = spawnPoints[rdm].position;
        animator.SetBool("Dead", false);
    }
}
