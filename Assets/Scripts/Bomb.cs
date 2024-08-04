using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosion;
    PlayerConditions playerConditions;

    private void Start()
    {
        playerConditions = FindAnyObjectByType<PlayerConditions>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!playerConditions.isCombed) //&& other.gameObject.GetComponent<PlayerConditions>() != null)
        {
            playerConditions.isDead = true;
            Debug.Log("Bomb");
            
            explosion.SetActive(true);
            
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
