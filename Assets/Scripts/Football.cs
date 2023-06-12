using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Football : MonoBehaviour
{
    public Score score;
    public Vector3 worldStartPostition;

    void Start()
    {
        worldStartPostition = transform.position;
       
    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            score.AddScore(1);
            this.transform.position = worldStartPostition;

        }
    }
}
