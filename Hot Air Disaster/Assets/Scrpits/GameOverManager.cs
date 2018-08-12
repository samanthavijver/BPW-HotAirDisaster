using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;       // Reference to the player's health.
    public GameObject FadeToBlack;

    Animator anim;                          // Reference to the animator component.
    Animator exit;


    void Awake()
    {
        // Set up the reference.
        anim = GetComponent<Animator>();
        exit = FadeToBlack.GetComponent<Animator>();
    }


    void Update()
    {
        // If the player has run out of health...
        if (playerHealth.currentHealth <= 0)
        {
            Time.timeScale = 0;
            // ... tell the animator the game is over.
            anim.SetTrigger("GameOver");
            

           if (Input.GetKeyDown(KeyCode.Space))
            {
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
              exit.SetTrigger("Fade");
            }
        }
    }
}