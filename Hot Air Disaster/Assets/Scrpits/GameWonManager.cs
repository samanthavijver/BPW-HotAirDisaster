using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameWonManager : MonoBehaviour
{
    public GameObject FadeToBlack;

    Animator anim;                          // Reference to the animator component.
    Animator exit;

    public int time;
    Text text;
    public float timer;


    void Awake()
    {
        // Set up the reference.
        anim = GetComponent<Animator>();
        timer = time;
        text = GetComponent<Text>();
        exit = FadeToBlack.GetComponent<Animator>();
    }


    void Update()
    {
        timer -= Time.deltaTime;
        text.text = "Time: " + timer.ToString("f");

        // If the player has survived said time
        if (timer <= 0f)
        {
            GameWon();
        }


    }

    public void GameWon()
    {
        Time.timeScale = 0;
        anim.SetTrigger("GameWon");

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