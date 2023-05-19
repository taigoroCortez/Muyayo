using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{

    
    public float shakeDuration = 0.2f; 
    public float shakeMagnitude = 0.7f; 

    private Vector3 originalPosition;

    void Awake()
    {
        FindObjectOfType<DeadPlayer>().DeadGroundPlayer += Aviio;
        
    }
    private void Start()
    {
        originalPosition = transform.localPosition;
    }

    void Aviio()
    {
        StartCoroutine(Shake());
    }
    public IEnumerator Shake()
    {
        float elapsed = 0f;

        while(elapsed < shakeDuration)
        {
            float x = Random.Range(-1f, 1f) * shakeMagnitude;
            float y = Random.Range(-1f, 1f) * shakeMagnitude;

            transform.localPosition = new Vector3(x, y, originalPosition.z);
            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.transform.localPosition = originalPosition;
    }
   
}

