using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text playerScore;
    public int score = 0;
    public int maxScore;
    public GameObject EndPanel;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    public void AddScore(int newScore)
    {
        score += newScore;
    }

    public void UpdateScore()
    {
        playerScore.text = "0" + score;
    }

    void Update()
    {
        UpdateScore();

    }
}
