using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class UIPages : MonoBehaviour
{
    public AudioSource button;
    public SpriteRenderer mainBall;
    public Animator settingsAnim;
    public Animator storeAnim;
    public Sprite ball_1;
    public Sprite ball_2;
    public Sprite ball_3;
    public Sprite ball_4;
    public Sprite ball_5;
    public void Replay()
    {
        SceneManager.LoadScene("Game");
        Score_Manager.Score = 0;
    }
  public void Play()
  {
        button.Play();
        SceneManager.LoadScene("Game");
  }

   public void Exit()
    {
        button.Play();
        Application.Quit();
    }
   
    public void Settings()
    {
        button.Play();
        settingsAnim.SetBool("Settings_pressed", true);
        
    }
    public void SettingsBack()
    {
        button.Play();
        settingsAnim.SetBool("Settings_pressed", false);
    }
    public void Store()
    {
        button.Play();
        storeAnim.SetBool("Store_Pressed", true);
    }
    public void StoreBack()
    {
        button.Play();
        storeAnim.SetBool("Store_Pressed", false);
    }

    public void Ball_01()
    {
        button.Play();
        mainBall.sprite = ball_1;
        SceneManager.LoadScene("Game");
    }
    public void Ball_02()
    {
        button.Play();
        mainBall.sprite = ball_2;
        SceneManager.LoadScene("Game");
    }
    public void Ball_03()
    {
        button.Play();
        mainBall.sprite = ball_3;
        SceneManager.LoadScene("Game");
    }
    public void Ball_04()
    {
        button.Play();
        mainBall.sprite = ball_4;
        SceneManager.LoadScene("Game");
    }
    public void Ball_05()
    {
        button.Play();
        mainBall.sprite = ball_5;
        SceneManager.LoadScene("Game");
    }


}
