using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class CountdownA : MonoBehaviour
{
    public Text countdownTextField;

    void Start()
    {
        StartCoroutine(CountdownCoroutine());
    }

    IEnumerator CountdownCoroutine()
    {
        countdownTextField.text = "3";
        yield return new WaitForSeconds(1.0f);
        countdownTextField.text = "2";
        yield return new WaitForSeconds(1.0f);
        countdownTextField.text = "1";
        yield return new WaitForSeconds(1.0f);
        countdownTextField.text = "GO";
        yield return new WaitForSeconds(1.0f);
        countdownTextField.text = "";
        yield return null;
    }

}