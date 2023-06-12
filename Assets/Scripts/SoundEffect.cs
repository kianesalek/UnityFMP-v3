using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource soundPlayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void buttonClick()
    {
        soundPlayer.Play();
    }
}
