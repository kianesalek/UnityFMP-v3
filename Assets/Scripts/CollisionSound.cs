using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{

    public AudioSource Audio;
    public AudioSource Audio2;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            //Audio.Play();
            //Audio2.Stop();
        }
    }   
}
