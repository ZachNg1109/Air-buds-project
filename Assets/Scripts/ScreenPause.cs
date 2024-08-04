using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPause : MonoBehaviour
{
    public float duration = 0.5f;
    
    private bool isPaused = false;
    private float pauseDuration = 0f;

    private void Update()
    {
        if(pauseDuration > 0 && !isPaused)
        {
            StartCoroutine(PauseNow()); 
        }
    }

    public void PauseScreen()
    {
        pauseDuration = duration;
    }

    public IEnumerator PauseNow()
    {
        isPaused = true;
        var ori = Time.timeScale;
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(duration);
        Time.timeScale = ori;
        pauseDuration = 0f;
        isPaused = false;
        Debug.Log(ori);
    }
}
