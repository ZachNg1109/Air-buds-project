using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementCheck : MonoBehaviour
{
    public CharactersObjects characterList;
    public Achievements achiev;

    int charOrder;
    float kilom;

    public GameObject tick1;
    public GameObject tick2;
    public GameObject tick3;
    public GameObject tick4;
        
    public GameObject tick5;
    public GameObject tick6;
        
    public GameObject tick7;
    public GameObject tick8;
    public GameObject tick9;
    public GameObject tick10;
        
    public GameObject tick11;
    public GameObject tick12;

    private void Awake()
    {
        if (characterList.Tappy == true)
        {
            charOrder = 1;
        }

        if (characterList.Bam == true)
        {
            charOrder = 2;
        }

        if (characterList.Biggie == true)
        {
            charOrder = 3;
        }

        if (characterList.Ogu == true)
        {
            charOrder = 4;
        }


    }

    private void Update()
    {
        if(achiev.ach1 == true)
        {

        }
        
        switch (charOrder)
        {
            case 1:
                kilom = PlayerPrefs.GetFloat("Tappy_Highscore");
                if (kilom > 50)
                {
                    achiev.ach1 = true;
                    tick1.SetActive(true);
                }
                if (kilom > 100)
                {
                    achiev.ach2 = true;
                    tick2.SetActive(true);

                }
                if (kilom > 200)
                {
                    achiev.ach3 = true;
                    tick3.SetActive(true);

                }
                break;

            case 2:
                kilom = PlayerPrefs.GetFloat("Bam_Highscore");

                if (kilom > 50)
                {
                    achiev.ach4 = true;
                    tick4.SetActive(true);

                }
                if (kilom > 100)
                {
                    achiev.ach5 = true;
                    tick5.SetActive(true);

                }
                if (kilom > 200)
                {
                    achiev.ach6 = true;
                    tick6.SetActive(true);

                }
                break;

            case 3:
                kilom = PlayerPrefs.GetFloat("Biggie_Highscore");

                if (kilom > 50)
                {
                    achiev.ach7 = true;
                    tick7.SetActive(true);

                }
                if (kilom > 100)
                {
                    achiev.ach8 = true;
                    tick8.SetActive(true);

                }
                if (kilom > 200)
                {
                    achiev.ach9 = true;
                    tick9.SetActive(true);

                }
                break;

            case 4:
                kilom = PlayerPrefs.GetFloat("Ogu_Highscore");

                if (kilom > 50)
                {
                    achiev.ach10 = true;
                    tick10.SetActive(true);

                }
                if (kilom > 100)
                {
                    achiev.ach11 = true;
                    tick11.SetActive(true);

                }
                if (kilom > 200)
                {
                    achiev.ach12 = true;
                    tick12.SetActive(true);

                }
                break;
        }
    }
}
