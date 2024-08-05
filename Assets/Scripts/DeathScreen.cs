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
    public GameObject sorry;
    public CharactersObjects charList;

    public GameObject tappyDeath;
    public GameObject bamDeath;
    public GameObject biggieDeath;
    public GameObject oguDeath;

    private int randomNum;

    private void Start()
    {
        playerConditions = FindAnyObjectByType<PlayerConditions>();
        imageShake = FindAnyObjectByType<ImageShake>();
        imageShake2 = FindAnyObjectByType<ImageShake2>();
        scoreManager = FindAnyObjectByType<ScoreManager>();
        deathScreen.SetActive(false);
        sorry.SetActive(false);
        randomNum = Random.Range(1, 100);

    }

    private void Update()
    {
        if (playerConditions.isDead && timer > 0)
        {
            if(randomNum > 35)
            {
                if(charList.Tappy == true)
                {
                    tappyDeath.SetActive(true);
                }
                else if (charList.Tappy == true)
                {
                    bamDeath.SetActive(true);
                }
                else if (charList.Tappy == true)
                {
                    biggieDeath.SetActive(true);
                }
                else if (charList.Tappy == true)
                {
                    oguDeath.SetActive(true);
                }
            }
            charList.isStarted = false;
            scoreManager.scoreIncreaseRate = 0;
            //need disable player control
            deathScreen.SetActive(true);
            timer -= Time.unscaledDeltaTime;
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
        //deathScreen.SetActive(false);
        //scoreManager.scoreIncreaseRate = 1;\
        sorry.SetActive(true );
    }

    public void BackButton()
    {
        deathScreen.SetActive(false);
        SceneManager.LoadScene("Start");
    }
}
