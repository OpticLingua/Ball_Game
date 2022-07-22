using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIPages : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("Game");
        Score_Manager.Score = 0;
    }
}
