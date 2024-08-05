using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveExcessProps : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Building"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Cloud"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Bomb"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Skills"))
        {
            Destroy(other.gameObject);
        }
    }
}
