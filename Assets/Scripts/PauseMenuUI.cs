using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuUI : MonoBehaviour
{
    public GameObject PausePanel;
    public static bool IsPaused = false;
    private void Start()
    {
        PausePanel.SetActive(false);
    }

    public void Pause()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        Cursor.visible = true;
        IsPaused = true;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        Cursor.visible = false;
        IsPaused = false;
    }
}
