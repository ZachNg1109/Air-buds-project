using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class DeathScreen : MonoBehaviour
{
    public GameObject deathScreen;

    PlayerConditions playerConditions;
    ImageShake imageShake;
    ImageShake2 imageShake2;
    ScoreManager scoreManager;

    public float timer = 10;
    public TextMeshProUGUI timerText;

    private void Start()
    {
        playerConditions = FindAnyObjectByType<PlayerConditions>();
        imageShake = FindAnyObjectByType<ImageShake>();
        imageShake2 = FindAnyObjectByType<ImageShake2>();
        scoreManager = FindAnyObjectByType<ScoreManager>();
        deathScreen.SetActive(false);
    }

    private void Update()
    {
        if (playerConditions.isDead && timer > 0)
        {
            scoreManager.scoreIncreaseRate = 0;
            //need disable player control
            deathScreen.SetActive(true);
            timer -= Time.deltaTime;
            timerText.text = Mathf.FloorToInt(timer).ToString();
            imageShake.StartShake();
            imageShake2.StartShake();
        }
        else if (timer <= 0)
        {
            timer = 0;
            BackButton();
        }
    }

    public void ContinueButton()
    {
        deathScreen.SetActive(false);
        scoreManager.scoreIncreaseRate = 1;
    }

    public void BackButton()
    {
        deathScreen.SetActive(false);
        SceneManager.LoadScene("Start");
    }
}
