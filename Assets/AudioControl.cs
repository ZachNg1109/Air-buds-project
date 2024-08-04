using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    GameManager gameManager;
    public void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    private void Update()
    {
        
    }
}
