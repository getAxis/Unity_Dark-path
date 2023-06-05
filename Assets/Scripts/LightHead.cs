using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHead : MonoBehaviour
{
    [SerializeField] float fadeKoef;
    private Light currentLight;
    private float intensity;

    float Intensity
    {
        get
        {
            return intensity;
        }
        set
        {
            intensity = value;
        }
    }
    float Fadekoef
    {
        get
        {
            return fadeKoef;
        }
        set
        {
            fadeKoef = value;
        }
    }


    private void Start()
    {
        currentLight = gameObject.GetComponent<Light>();
    }
    private void Update()
    {
        intensity = currentLight.intensity;
    }

    private void FixedUpdate()
    {
        currentLight.intensity -= fadeKoef*Time.deltaTime;        
    }
    
}
