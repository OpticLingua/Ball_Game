using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuUI : MonoBehaviour
{
    public AudioSource button;
    public AudioSource game;
    public GameObject PausePanel;
    public static bool IsPaused = false;
    private void Start()
    {
        PausePanel.SetActive(false);
    }

    public void Pause()
    {
        button.Play();
        game.Stop();
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        Cursor.visible = true;
        IsPaused = true;
    }

    public void Resume()
    {
        game.Play();
        button.Play();
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        Cursor.visible = false;
        IsPaused = false;
    }

    public void MainMenu()
    {
        button.Play();
        SceneManager.LoadScene("HomePage");
    }
}
