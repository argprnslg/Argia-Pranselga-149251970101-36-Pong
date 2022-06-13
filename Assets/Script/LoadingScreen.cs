using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider loadingBar;
    public void LoadScene(int levelIndex)
    {
        StartCoroutine(LoadSceneAsynchronously(levelIndex));
    }

    IEnumerator LoadSceneAsynchronously(int LevelIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Game");
        loadingScreen.SetActive(true);
        while(!operation.isDone)
        {
            loadingBar.value = operation.progress;
            yield return null;
            Debug.Log("Created by Argia Pranselga - 149251970101-36");
        }
    }
}
