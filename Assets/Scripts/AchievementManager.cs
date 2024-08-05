using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public GameObject characterMenu;
    public GameObject achievementMenu;
    public GameObject achievementMenu2;

    public GameObject achievementButtons;
    public AudioManager audioManager;
    public GameObject char3d;

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
            achievementMenu2.SetActive(false);
            achievementButtons.SetActive(true);
            char3d.SetActive(false);
        }
        else
        {
            audioManager.PlaySFX("TrophyClose");
            characterMenu.SetActive(true);
            achievementMenu.SetActive(false);
            achievementMenu2.SetActive(false);
            achievementButtons.SetActive(false);
            char3d.SetActive(true);

        }

    }
}
