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
    void Start()
    {
        highscore = PlayerPrefs.GetFloat("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = Score.ToString();
        highscoretext.text = highscore.ToString();
        if (Score>highscore)
            PlayerPrefs.SetFloat("highscore",Score);
    }

    public void DeletePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
