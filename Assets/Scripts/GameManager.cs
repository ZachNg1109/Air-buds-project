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

    private void Awake()
    {
        PlayerPrefs.SetInt("Stars", 0);

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
            Time.timeScale = 1f;

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
