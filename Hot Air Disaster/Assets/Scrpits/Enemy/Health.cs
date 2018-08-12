using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public const int maxHealth = 100;
    public int currentHealth = maxHealth;
    public int scoreValue = 10;               // The amount added to the player's score when the enemy dies.
    public GameObject explodePrefab;

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            ScoreManager.score += scoreValue;
            Instantiate(explodePrefab,gameObject.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }

}
