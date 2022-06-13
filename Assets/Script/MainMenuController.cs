using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created by Argia Pranselga - 149251970101-36");
    }

    public void InfoGame()
    {
        SceneManager.LoadScene("Info");
    }
    
    public void BackMainMenu()
    {
        SceneManager.LoadScene("Main Menu 1");
    }
}
