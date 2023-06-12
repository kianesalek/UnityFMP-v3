using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSDisplay : MonoBehaviour
{
    public TextMeshProUGUI FpsText;
    private float pollingTime = 0.3f;
    private float time;
    private int frameCount;

    // Update is called once per frame
    void Update()
    {
        time += Time.unscaledDeltaTime;

        frameCount++;

        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / pollingTime);
            FpsText.text = frameRate.ToString() + "FPS";

            time -= pollingTime;
            frameRate = 0;
        }
    }
}
