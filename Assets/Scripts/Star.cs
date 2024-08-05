using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Star : MonoBehaviour
{
    StarSystem starSystem;
    public CharactersObjects charList;
    
    private void Start()
    {
        starSystem = FindAnyObjectByType<StarSystem>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<PlayerConditions>() != null)
        {
            starSystem.starCount++;
            charList.StarsCollected += starSystem.starCount;
            int totalStars = charList.StarsCollected + PlayerPrefs.GetInt("Stars");
            PlayerPrefs.SetInt("Stars", totalStars);
            Destroy(gameObject);
        }
        

       
    }
}
