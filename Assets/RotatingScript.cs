using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingScript : MonoBehaviour
{
    public float rotationSpeed = 45f; // Rotation speed in degrees per second

    // Update is called once per frame
    void Update()
    {
        float rotationStep = rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, 0f, rotationStep);
    }
}
