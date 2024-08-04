using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradualSpeed : MonoBehaviour
{

    float thresholdValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        thresholdValue += Time.unscaledDeltaTime;
        if(thresholdValue > 10f)
        {
            Time.timeScale += 0.001f;
        }

    }
}
