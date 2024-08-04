using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float flyingSpeed;
    [SerializeField] private float maximumRotation;

    private float currentRotationX = 0f;
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
                float rotationX = -touch.deltaPosition.x * flyingSpeed * Time.deltaTime;
                currentRotationX += rotationX;
                currentRotationX = Mathf.Clamp(currentRotationX, -maximumRotation, maximumRotation);
                transform.localRotation = Quaternion.Euler(currentRotationX, transform.localRotation.eulerAngles.y, transform.localRotation.eulerAngles.z);

            }
        }
    }
}
