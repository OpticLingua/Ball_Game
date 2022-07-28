using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIPages : MonoBehaviour
{
    public GameObject Pausepanel;
    public static bool IsPaused = false;
    private void Start()
    {
        Pausepanel.SetActive(false);
    }
    public void Replay()
    {
        SceneManager.LoadScene("Game");
        Score_Manager.Score = 0;
    }

    public void Pause()
    {
        Time.timeScale = 0;
        Pausepanel.SetActive(true);
        Cursor.visible = true;
        IsPaused = true;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        Pausepanel.SetActive(false);
        Cursor.visible = false;
        IsPaused=false;
    }
}
