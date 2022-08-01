using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIPages : MonoBehaviour
{
    private GameObject Pausepanel;
    public static bool IsPaused = false;
    public Animator settings;
    public Animator store;
    //private  Animator AnimSettings;
    //private Animator AnimStore;
     public  void Start()
    {
        Pausepanel= GameObject.FindWithTag("PausePanel");
        Pausepanel.SetActive(false);
        //settings = GameObject.FindWithTag("Settings");
        //store= GameObject.FindWithTag("Store");
       //AnimSettings = settings.GetComponent<Animator>();
        //AnimStore = store.GetComponent<Animator>();
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

   public void Play()
   {
        SceneManager.LoadScene("Game");
   }

   public void Exit()
    {
        Application.Quit();
    }
   
    public void Settings()
    {
        settings.SetBool("Settings_pressed", true);
    }
    public void SettingsBack()
    {
        settings.SetBool("Settings_pressed", false);
    }
    public void Store()
    {
        store.SetBool("Store_Pressed", true);
    }
    public void StoreBack()
    {
        store.SetBool("Store_Pressed", false);
    }

    
}
