using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public float maxHealth;
    public Transform spawnPoints;
    public float timeToRespawn;
    private float currentHealth;
    public PlayerHealthBar healthBar;
    public RespawnCircle respawnCircle;
    private Animator animator;

    private bool dead = false;

    public AudioClip degatPerso;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.Find("PlayerSpawnPoint").transform;
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
        respawnCircle.gameObject.SetActive(false);
    }

    public void TakeDamage(float amount)
    {
        if(!dead)
        {
            //on prend es degats
            currentHealth -= amount;
            if (currentHealth <= 0) //le player est mort
            {
                currentHealth = 0;
                StartCoroutine(Die());
                dead = true;
            }
            //on update la barre de vie

        }
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
        animator.SetBool("Dead", true);
        GetComponent<PlayerController>().enabled = false;
        respawnCircle.timeTimeToRespawn = timeToRespawn;
        respawnCircle.gameObject.SetActive(true);

        yield return new WaitForSeconds(timeToRespawn);

        dead = false;
        respawnCircle.Reset();
        respawnCircle.gameObject.SetActive(false);
        currentHealth = maxHealth;
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
        GetComponent<PlayerController>().enabled = true;
        transform.position = spawnPoints.position;
        animator.SetBool("Dead", false);
    }
}
