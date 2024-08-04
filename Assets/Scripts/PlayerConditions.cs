using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConditions : MonoBehaviour
{
    public bool isDead = false;

    public bool isSunGlasses;
    public bool isCombed;
    public GameObject cloudyEffect;

    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (isSunGlasses)
        {
            if (other.CompareTag("Cloud"))
            {
                isSunGlasses = false;
            }
        }
        else if (!isSunGlasses && other.CompareTag("Cloud"))
        {
            StartCoroutine(ShowCloudyEffect());
        }
    }

    private IEnumerator ShowCloudyEffect()
    {
        cloudyEffect.SetActive(true);
        yield return new WaitForSeconds(3f);
        cloudyEffect.SetActive(false);
    }
}
    