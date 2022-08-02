using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score_Manager : MonoBehaviour
{
    public Text scoretext;
    public static float Score;
    public static float highscore;
    public Text highscoretext;
    public static float highpoints;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    void Start()
    {
        highscore = PlayerPrefs.GetFloat("highscore");
    }
    void Update()
    {
        scoretext.text = Score.ToString();
        highscoretext.text = highscore.ToString();
        if (Score>highscore)
            PlayerPrefs.SetFloat("highscore",Score);
        highpoints = PlayerPrefs.GetFloat("highscore");
        if(highpoints>=100)
            button1.interactable=true;
        else 
            button1.interactable=false;
        if (highpoints >= 200)
            button2.interactable = true;
        else
            button2.interactable = false;
        if(highpoints>=300)
            button3.interactable=true;
        else
            button3.interactable = false;
        if(highpoints>=400)
            button4.interactable=true;
        else
            button4.interactable = false;
    }
    public void DeletePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
