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
    public GameObject tappyskill;
    public GameObject bamskill;
    public GameObject biggieskill;
    public GameObject oguskill;

    public GameObject tappyCutscene;
    public GameObject oguCutscene;
    public GameObject bamCutscene;
    public GameObject biggieCutscene;


    AudioManager audioManager;
    private bool actionPerformed = false;
    float thresholdValue;

    private void Awake()
    {
        audioManager = FindAnyObjectByType<AudioManager>();

        if (charList.Tappy == true)
        {
            Atappy.SetActive(true);
            tappyCutscene.SetActive(true);
        }
        else if (charList.Bam == true)
        {
            ABam.SetActive(true);
            bamCutscene.SetActive(true);

        }
        else if (charList.Biggie == true)
        {
            ABiggie.SetActive(true);
            biggieCutscene.SetActive(true);

        }
        else if (charList.Ogu == true)
        {
            AOgu.SetActive(true);
            oguCutscene.SetActive(true);

        }

        charList.isStarted = true;

    }
    private void Update()
    {
        if(charList.isStarted == false)
        {
            Time.timeScale = 0f;
        }

        if (cutsceneIntro.state == PlayState.Playing)
        {
            Time.timeScale = 0f;
            
        }
        else if(cutsceneIntro.state == PlayState.Paused && charList.isStarted == true)
        {
            thresholdValue += Time.unscaledDeltaTime;
            if (thresholdValue < 18f)
            {
                Time.timeScale = 1f;

            }
            else if (thresholdValue > 18f)
            {
                Time.timeScale += 0.0001f;
            }

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
            //tappyskill.SetActive(true);
        }
        else if(charList.Bam == true)
        {
            ABam.SetActive(true);
            //bamskill.SetActive(true);

        }
        else if (charList.Biggie == true)
        {
            ABiggie.SetActive(true);
            //biggieskill.SetActive(true);

        }
        else if (charList.Ogu == true)
        {
            AOgu.SetActive(true);
           // oguskill.SetActive(true);

        }
    }


}
