using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHead : MonoBehaviour
{
    [SerializeField] float fadeKoef;
    private Light currentLight;
    private float intensity;

    public float Intensity
    {
        get
        {
            return currentLight.intensity;
        }
        set
        {
            currentLight.intensity = value;
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

    }

    private void FixedUpdate()
    {
        currentLight.intensity -= fadeKoef*Time.deltaTime;        
    }
    
}
