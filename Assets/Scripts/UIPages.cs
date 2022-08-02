using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class UIPages : MonoBehaviour
{
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
        SceneManager.LoadScene("Game");
   }

   public void Exit()
    {
        Application.Quit();
    }
   
    public void Settings()
    {
        settingsAnim.SetBool("Settings_pressed", true);
        
    }
    public void SettingsBack()
    {
        settingsAnim.SetBool("Settings_pressed", false);
    }
    public void Store()
    {
        storeAnim.SetBool("Store_Pressed", true);
    }
    public void StoreBack()
    {
        storeAnim.SetBool("Store_Pressed", false);
    }

    public void Ball_01()
    {
        mainBall.sprite = ball_1;
        SceneManager.LoadScene("Game");
    }
    public void Ball_02()
    {
        mainBall.sprite = ball_2;
        SceneManager.LoadScene("Game");
    }
    public void Ball_03()
    {
        mainBall.sprite = ball_3;
        SceneManager.LoadScene("Game");
    }
    public void Ball_04()
    {
        mainBall.sprite = ball_4;
        SceneManager.LoadScene("Game");
    }
    public void Ball_05()
    {
        mainBall.sprite = ball_5;
        SceneManager.LoadScene("Game");
    }


}
