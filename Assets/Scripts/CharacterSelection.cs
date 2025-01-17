using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject confirmButton;

    public GameObject arrowTappy;
    public GameObject arrowBam;
    public GameObject arrowBiggie;
    public GameObject arrowOgu;

    public GameObject tappyHighscore;
    public GameObject bamHighscore;
    public GameObject biggieHighscore;
    public GameObject oguHighscore;

    public GameObject tappy3D;
    public GameObject bam3D;
    public GameObject biggie3D;
    public GameObject ogu3D;

    public CharactersObjects charList;
    private int order;

    AudioManager audioManager;
    public void Start()
    {
        confirmButton.SetActive(false);
        arrowTappy.SetActive(false);
        arrowBam.SetActive(false);
        arrowBiggie.SetActive(false);
        arrowOgu.SetActive(false);

        audioManager = FindAnyObjectByType<AudioManager>();
    }
    public void SetActiveArrow(GameObject activeArrow)
    {
        arrowTappy.SetActive(false);
        arrowBam.SetActive(false);
        arrowBiggie.SetActive(false);
        arrowOgu.SetActive(false);

        if (activeArrow != null)
        {
            activeArrow.SetActive(true);
        }
    }
    public void PickTappy()
    {
        confirmButton.SetActive(true);
        tappyHighscore.SetActive(true);
        bamHighscore.SetActive(false);
        biggieHighscore.SetActive(false);
        oguHighscore.SetActive(false);

        tappy3D.SetActive(true);

        bam3D.SetActive(false);
        biggie3D.SetActive(false);
        ogu3D.SetActive(false);

        audioManager.PlaySFX("Hover");
        SetActiveArrow(arrowTappy);
        order = 1;
    }

    public void PickBam()
    {
        confirmButton.SetActive(true);
        bamHighscore.SetActive(true);
        tappyHighscore.SetActive(false);
        biggieHighscore.SetActive(false);
        oguHighscore.SetActive(false);

        bam3D.SetActive(true);

        tappy3D.SetActive(false);
        biggie3D.SetActive(false);
        ogu3D.SetActive(false);

        audioManager.PlaySFX("Hover");
        SetActiveArrow(arrowBam);
        order = 2;
    }

    public void PickBiggie()
    {
        confirmButton.SetActive(true);
        biggieHighscore.SetActive(true);
        tappyHighscore.SetActive(false);
        bamHighscore.SetActive(false);
        oguHighscore.SetActive(false);

        biggie3D.SetActive(true);

        bam3D.SetActive(false);
        tappy3D.SetActive(false);
        ogu3D.SetActive(false);

        audioManager.PlaySFX("Hover");
        SetActiveArrow(arrowBiggie);
        order = 3;
    }

    public void PickOgu()
    {
        confirmButton.SetActive(true);
        oguHighscore.SetActive(true);
        tappyHighscore.SetActive(false);
        bamHighscore.SetActive(false);
        biggieHighscore.SetActive(false);

        ogu3D.SetActive(true);

        bam3D.SetActive(false);
        biggie3D.SetActive(false);
        tappy3D.SetActive(false);

        audioManager.PlaySFX("Hover");
        SetActiveArrow(arrowOgu);
        order = 4;
    }

    public void Confirm()
    {
        switch (order)
        {
            case 1:
                charList.Tappy = true;
                break;
            case 2:
                charList.Bam = true;
                break;
            case 3:
                charList.Biggie = true;
                break;
            case 4:
                charList.Ogu = true;
                break;
        }
        audioManager.PlaySFX("Confirm");
        audioManager.MusicVolume(0f);
        SceneManager.LoadScene(1);
    }   
}
