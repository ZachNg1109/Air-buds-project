using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float flyingSpeed;
    [SerializeField] private float maximumRotation;

    private float currentRotationY = 0f;
    void Update()
    {
        if (Input.touchCount > 0) 
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {

            }

            if (touch.phase == TouchPhase.Moved)
            {
                float rotationY = touch.deltaPosition.x * flyingSpeed * Time.deltaTime;
                currentRotationY += rotationY;
                currentRotationY = Mathf.Clamp(currentRotationY, -maximumRotation, maximumRotation);
                transform.localRotation = Quaternion.Euler(transform.localRotation.eulerAngles.x, currentRotationY, transform.localRotation.eulerAngles.z);

            }
        }
    }
}
