using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject pauseMenu;

    public GameOver_Menu gameOverMenu;
    public GameWin_Menu gameWinMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            bool a = gameOverMenu.activated();
            bool b = gameWinMenu.activated();
            if (!a && !b)
            {
                if (isPaused)
                {
                    Resume();
                }
                    
                else  
                {
                    Pause();
                }
            }
        }
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; ;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void loadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
