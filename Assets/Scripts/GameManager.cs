using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    public PlayableDirector cutsceneIntro;
    public CharactersObjects charList;

    public GameObject Atappy;
    public GameObject ABam;
    public GameObject ABiggie;
    public GameObject AOgu;

    AudioManager audioManager;
    private bool actionPerformed = false;

    private void Awake()
    {
        audioManager = FindAnyObjectByType<AudioManager>();

        if (charList.Tappy == true)
        {
            Atappy.SetActive(true);
        }
        else if (charList.Bam == true)
        {
            ABam.SetActive(true);

        }
        else if (charList.Bam == true)
        {
            ABiggie.SetActive(true);

        }
        else if (charList.Bam == true)
        {
            AOgu.SetActive(true);

        }
    }
    private void Update()
    {
        if (cutsceneIntro.state == PlayState.Playing)
        {
            Time.timeScale = 0f;
        }
        else if(cutsceneIntro.state == PlayState.Paused)
        {
            Time.timeScale = 1f;

            if (!actionPerformed )
            {
                audioManager.MusicVolume(1f);
                audioManager.PlayMusic("InGameBGM");
                actionPerformed = true;
            }
        }

        if(charList.Tappy == true)
        {
            Atappy.SetActive(true);
        }
        else if(charList.Bam == true)
        {
            ABam.SetActive(true);

        }
        else if (charList.Bam == true)
        {
            ABiggie.SetActive(true);

        }
        else if (charList.Bam == true)
        {
            AOgu.SetActive(true);

        }
    }


}
