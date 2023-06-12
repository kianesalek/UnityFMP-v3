using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingScriptPlayer : MonoBehaviour
{
    public Text playerScore;
    public GameObject EndPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScore.text == "2")
        {
            EndPanel.SetActive(true);
            Time.timeScale = 0.2f;
        }
    }
}
