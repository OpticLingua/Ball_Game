using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score_Manager : MonoBehaviour
{
    public Text score_text;
    public static int score = 0;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = "Score - " + score;
    }
}
