using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pause_menu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject loadScreen;
    public Slider loadBar;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("The game");
    }

    public void RestartSecond()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("The game lvl 2");
    }

    public void RestartThird()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Third level");
    }

    public void NextLevel()
    {
        loadScreen.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(LoadAsync());
    }

    IEnumerator LoadAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        asyncLoad.allowSceneActivation = false;
        while (!asyncLoad.isDone)
        {
            float progr = asyncLoad.progress / 0.9f;
            loadBar.value = progr;

            if (asyncLoad.progress >= .9f && !asyncLoad.allowSceneActivation)
            {
                if (Input.touchCount > 0)
                {
                    asyncLoad.allowSceneActivation = true;
                }
            }
            yield return null;
        }
    }

    public void RestartBoss()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("BossLevelFour");
    }
}
