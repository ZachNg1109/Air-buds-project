using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    StarSystem starSystem;
    private void Start()
    {
        starSystem = FindAnyObjectByType<StarSystem>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        starSystem.starCount ++;
        Destroy(gameObject);
    }
}
