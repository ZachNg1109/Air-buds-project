using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public GameObject characterMenu;
    public GameObject achievementMenu;
    public GameObject achievementButtons;
    public AudioManager audioManager;

    private void Start()
    {
         audioManager = FindAnyObjectByType<AudioManager>();
    }
    public void openAchievementButton()
    {

        if (characterMenu.activeInHierarchy)
        {
            audioManager.PlaySFX("Trophy");
            characterMenu.SetActive(false);
            achievementMenu.SetActive(true);
            achievementButtons.SetActive(true);
        }
        else
        {
            audioManager.PlaySFX("TrophyClose");
            characterMenu.SetActive(true);
            achievementMenu.SetActive(false);
            achievementButtons.SetActive(false);
        }

    }
}
