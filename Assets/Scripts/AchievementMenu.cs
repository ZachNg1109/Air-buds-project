using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementMenu : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;
    public void Next()
    {
        page1.SetActive(false);
        page2.SetActive(true);
    }

    public void Back()
    {
        page2.SetActive(false);
        page1.SetActive(true);
    }
}
