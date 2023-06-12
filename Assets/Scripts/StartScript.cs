using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private IEnumerator PauseForSeconds(float pauseDuration)
    {
        float originalTimeScale = Time.timeScale; 
        Time.timeScale = 0; 
        float t = 0;
        while (t < pauseDuration)
        {
            yield return null; 
            t += Time.unscaledDeltaTime; 
        }
        Time.timeScale = originalTimeScale;
    }
}
