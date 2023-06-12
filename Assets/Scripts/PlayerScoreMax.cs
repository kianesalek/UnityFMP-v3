using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScoreMax : MonoBehaviour
{
    public Transform Player;
    public Text scoretext;

    // Update is called once per frame
    void Update()
    {
        scoretext.text = Player.position.z.ToString("0");
        if (scoretext.text == "07")
        {
            SceneManager.LoadScene("Menu");
        }

    }
}