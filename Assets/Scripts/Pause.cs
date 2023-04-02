using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public Button resumeButton;
    public Button EndgameButton;
    private bool isPaused = false;





    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
                
            }
            else
            {
                PauseGame();
            }
        }

    }
    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        resumeButton.gameObject.SetActive(true);
        EndgameButton.gameObject.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        resumeButton.gameObject.SetActive(false);
        EndgameButton.gameObject.SetActive(false);
    }

    public void Endgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
