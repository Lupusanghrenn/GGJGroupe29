using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public float maxHealth;

    private float currentHealth;
    public PlayerHealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        //on prend es degats
        currentHealth -= amount;
        if (currentHealth <= 0) //le player est mort
        {
            currentHealth = 0;
            Die();
        }
        //on update la barre de vie
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
    }

    public void Die()
    {
        //TODO : remplir cetrte fonction  pour la mort du joueur
    }
}
