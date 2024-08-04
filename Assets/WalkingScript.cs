using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScript : MonoBehaviour
{
    public float rotationSpeed = 90f; // Rotation speed in degrees per second
    public float minRotationAngle = -110f; // The minimum angle to rotate to
    public float maxRotationAngle = -70f; // The maximum angle to rotate to

    private float currentAngle;
    private bool rotatingUp = true;

    private void Start()
    {
        // Initialize currentAngle to minRotationAngle
        currentAngle = minRotationAngle;
    }

    private void Update()
    {
        float rotationStep = rotationSpeed * Time.deltaTime;

        if (rotatingUp)
        {
            currentAngle += rotationStep;
            if (currentAngle >= maxRotationAngle)
            {
                currentAngle = maxRotationAngle;
                rotatingUp = false;
            }
        }
        else
        {
            currentAngle -= rotationStep;
            if (currentAngle <= minRotationAngle)
            {
                currentAngle = minRotationAngle;
                rotatingUp = true;
            }
        }

        transform.localRotation = Quaternion.Euler(currentAngle, -90f, 90f);
    }
}
