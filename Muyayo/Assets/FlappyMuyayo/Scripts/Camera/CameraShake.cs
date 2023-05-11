using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Transform cameraTransform; // Referencia al transform de la cámara
    public float shakeDuration = 0f; // Duración de la sacudida
    public float shakeMagnitude = 0.7f; // Magnitud de la sacudida

    private Vector3 originalPosition; // Posición original de la cámara

    void Awake()
    {
        if (cameraTransform == null)
        {
            cameraTransform = GetComponent(typeof(Transform)) as Transform;
        }
    }

    void OnEnable()
    {
        originalPosition = cameraTransform.localPosition;
    }

    void Update()
    {
        if (shakeDuration > 0)
        {
            cameraTransform.localPosition = originalPosition + Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime;
        }
        else
        {
            shakeDuration = 0f;
            cameraTransform.localPosition = originalPosition;
        }
    }

    public void ShakeCamera(float duration, float magnitude)
    {
        shakeDuration = duration;
        shakeMagnitude = magnitude;
    }
}

