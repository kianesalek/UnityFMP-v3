using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour
{
    public Text enemyScore;
    public int scoreA = 0;
    public int maxScore1;
    void Start()
    {
        scoreA = 0;
    }

    // Update is called once per frame
    public void AddScoreEnemy(int scoreEnemy)
    {
        scoreA += scoreEnemy;
    }

    public void UpdateScoreEnemy()
    {
        enemyScore.text = "0" + scoreA;
    }

    void Update()
    {
        UpdateScoreEnemy();
    }
}
