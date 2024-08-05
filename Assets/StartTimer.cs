using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
    public TextMeshProUGUI startTimerText;

    void OnEnable()
    {
        StartCoroutine(Countdown());
        startTimerText = GetComponent<TextMeshProUGUI>();
    }

    private IEnumerator Countdown()
    {
        startTimerText.color = Color.yellow;
        startTimerText.text = "Ready?";
        yield return new WaitForSecondsRealtime(1f);
        startTimerText.color = Color.green;
        startTimerText.text = "Start!";
        
    }
}
