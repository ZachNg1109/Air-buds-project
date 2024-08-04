using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject characterSelectionPage;

    public AudioManager audioManager;

    private void Start()
    {
        audioManager = FindAnyObjectByType<AudioManager>();
        characterSelectionPage.SetActive(false);
        gameObject.SetActive(true);
    }
    public void StartGame()
    {
        characterSelectionPage.SetActive(true);
        gameObject.SetActive(false);
        audioManager.PlaySFX("Start");
    }
}
