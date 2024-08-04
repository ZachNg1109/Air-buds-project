using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageShake : MonoBehaviour
{
    [SerializeField] private RectTransform imageTransform; // The RectTransform of the image to shake
    [SerializeField] private float shakeDuration = 0.5f; // Duration of the shake effect
    [SerializeField] private float shakeMagnitude = 20f; // Magnitude of the shake effect

    private Vector3 originalPosition;

    private void Start()
    {
        if (imageTransform == null)
        {
            imageTransform = GetComponent<RectTransform>();
        }
        originalPosition = imageTransform.localPosition;
    }

    public void StartShake()
    {
        StartCoroutine(Shake());
    }

    private IEnumerator Shake()
    {
        float elapsed = 0.0f;

        while (elapsed < shakeDuration)
        {
            float offsetX = Random.Range(-1f, 1f) * shakeMagnitude;
            float offsetY = Random.Range(-1f, 1f) * shakeMagnitude;

            imageTransform.localPosition = new Vector3(originalPosition.x + offsetX, originalPosition.y + offsetY, originalPosition.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        imageTransform.localPosition = originalPosition;
    }
}
