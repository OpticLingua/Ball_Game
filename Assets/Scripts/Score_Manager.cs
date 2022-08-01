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
        //Debug.Log(highpoints.ToString());
       // Debug.Log(Score_Manager.highpoints.ToString());
    }
    public void DeletePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
