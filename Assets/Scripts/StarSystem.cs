using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StarSystem : MonoBehaviour
{
    public int starCount;

    public TextMeshProUGUI starText;

    public CharactersObjects charList;

    private void Awake()
    {
        charList.StarsCollected = 0;

    }

    private void Update()
    {
        starText.text = charList.StarsCollected.ToString();
        
    }

}
