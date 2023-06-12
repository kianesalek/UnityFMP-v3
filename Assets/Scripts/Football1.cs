using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Football1 : MonoBehaviour
{
    public Score1 scoreA;
    public Vector3 worldStartPostition;

    void Start()
    {
        worldStartPostition = transform.position;

    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "GoalEnemy")
        {
            scoreA.AddScoreEnemy(1);
            this.transform.position = worldStartPostition;
        }
    }
}