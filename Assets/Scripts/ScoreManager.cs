using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public float scoreIncreaseRate = 1.0f;
    public CharactersObjects characterList;
    public MovingGlobe globe;

    private float score = 0f;

    private void Start()
    {
        
    }

    private void Update()
    {
        characterList.distance = score;
        if(globe.speed == 20f)
        {
            scoreIncreaseRate = 1.0f;
        }

        if(globe.speed == 200f)
        {
            scoreIncreaseRate = 10f;
        }

        if(globe.speed == 8f)
        {
            scoreIncreaseRate = 0.4f;
        }

        score += scoreIncreaseRate * Time.deltaTime;

        scoreText.text = Mathf.FloorToInt(score).ToString() + " km";

        if(characterList.Tappy == true)
        {
            float highest = PlayerPrefs.GetFloat("Tappy_Highscore");
            if(score > highest)
                PlayerPrefs.SetFloat("Tappy_Highscore", score);
        }
        else if (characterList.Bam == true)
        {
            float highest = PlayerPrefs.GetFloat("Bam_Highscore");
            if (score > highest)
                PlayerPrefs.SetFloat("Bam_Highscore", score);
        }
        else if (characterList.Biggie == true)
        {
            float highest = PlayerPrefs.GetFloat("Biggie_Highscore");
            if (score > highest)
                PlayerPrefs.SetFloat("Biggie_Highscore", score);
        }
        else if (characterList.Ogu == true)
        {
            float highest = PlayerPrefs.GetFloat("Ogu_Highscore");
            if (score > highest)
                PlayerPrefs.SetFloat("Ogu_Highscore", score);
        }

    }
}
