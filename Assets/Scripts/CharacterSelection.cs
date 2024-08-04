using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject confirmButton;

    public GameObject arrowTappy;
    public GameObject arrowBam;
    public GameObject arrowBiggie;
    public GameObject arrowOgu;

    public CharactersObjects charList;
    private int order;

    public TMP_Text Tappytext;


    public void Start()
    {
        confirmButton.SetActive(false);
        arrowTappy.SetActive(false);
        arrowBam.SetActive(false);
        arrowBiggie.SetActive(false);
        arrowOgu.SetActive(false);
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
        SetActiveArrow(arrowTappy);
        order = 1;

        Tappytext.text = ("Longest Distance: " + PlayerPrefs.GetFloat("Tappy_Highscore").ToString() + " KM");
    }

    public void PickBam()
    {
        confirmButton.SetActive(true);
        SetActiveArrow(arrowBam);
        order = 2;
    }

    public void PickBiggie()
    {
        confirmButton.SetActive(true);
        SetActiveArrow(arrowBiggie);
        order = 3;
    }

    public void PickOgu()
    {
        confirmButton.SetActive(true);
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

        SceneManager.LoadScene(1);
    }
}
