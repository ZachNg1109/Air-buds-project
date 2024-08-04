using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public GameObject characterMenu;
    public GameObject achievementMenu;
    public GameObject achievementButtons;
    public void openAchievementButton()
    {
        if (characterMenu.activeInHierarchy)
        {
            characterMenu.SetActive(false);
            achievementMenu.SetActive(true);
            achievementButtons.SetActive(true);
        }
        else
        {
            characterMenu.SetActive(true);
            achievementMenu.SetActive(false);
            achievementButtons.SetActive(false);
        }

    }
}
