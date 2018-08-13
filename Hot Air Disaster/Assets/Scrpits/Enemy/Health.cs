using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public const int maxHealth = 100;
    public int currentHealth = maxHealth;
    public Slider healthSlider;                                 // Reference to the UI's health bar.
    public int scoreValue = 10;               // The amount added to the player's score when the enemy dies.
    public GameObject explodePrefab;



    public void TakeDamage(int amount)
    {
        // Reduce the current health by the damage amount.
        currentHealth -= amount;

        // Set the health bar's value to the current health.
        healthSlider.value = currentHealth;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            ScoreManager.score += scoreValue;
            Instantiate(explodePrefab,gameObject.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }

}
