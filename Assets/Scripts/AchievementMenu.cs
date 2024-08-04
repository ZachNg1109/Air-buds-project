using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementMenu : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;

    public GameObject nextButton;
    public GameObject backButton;

    AudioManager audioManager;

    private void Start()
    {
        audioManager = FindAnyObjectByType<AudioManager>();
    }

    private void Update()
    {
        if (page1.activeInHierarchy)
        {
            nextButton.SetActive(true);
            backButton.SetActive(false);
        }
        if (page2.activeInHierarchy)
        {
            backButton.SetActive(true);
            nextButton.SetActive(false);
        }
    }
    public void Next()
    {
        audioManager.PlaySFX("Flip");
        page1.SetActive(false);
        page2.SetActive(true);
    }

    public void Back()
    {
        audioManager.PlaySFX("Flip");
        page2.SetActive(false);
        page1.SetActive(true);
    }
}
