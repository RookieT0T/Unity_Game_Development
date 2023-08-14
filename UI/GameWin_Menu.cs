using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin_Menu : MonoBehaviour
{
    public bool isActivated = false;

    public void setUp()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gameObject.SetActive(true);
        isActivated = true;
        Time.timeScale = 0f;
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void retry()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public bool activated()
    {
        return isActivated;
    }
}
