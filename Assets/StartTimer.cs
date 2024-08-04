using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
    public TextMeshProUGUI startTimerText;

    void Start()
    {
        StartCoroutine(Countdown());
        startTimerText = GetComponent<TextMeshProUGUI>();
    }

    private IEnumerator Countdown()
    {
        startTimerText.color = Color.yellow;
        startTimerText.text = "Ready?";
        yield return new WaitForSeconds(1);
        startTimerText.color = Color.green;
        startTimerText.text = "Start!";
        yield return new WaitForSeconds(1);

        Destroy(gameObject);
    }
}
