using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour {

    
    public bool paused = false;
    public Button ResumeButton;
    public Button OptionsButton;
    public Button QuitButton;
    public Button HowToButton;
    public GameObject PausedPanel;

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
            
        }

    }

    public void ResumeGame()
    {
        paused = false;
        Debug.Log("GameResumes");
        ResumeButton.interactable = false;
        HowToButton.interactable = false;
        OptionsButton.interactable = false;
        QuitButton.interactable = false;
        animator.SetTrigger("Close");
        Cursor.visible = false;
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        animator.SetTrigger("Open");
        paused = true;
        ResumeButton.interactable = true;
        HowToButton.interactable = true;
        OptionsButton.interactable = true;
        QuitButton.interactable = true;
        Debug.Log("GamePaused");
        Cursor.visible = true;
        Time.timeScale = 0;
    }

}
