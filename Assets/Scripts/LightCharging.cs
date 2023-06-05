using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCharging : MonoBehaviour
{


    private LightHead lightHead;
    private void Start()
    {
        lightHead = GameObject.Find("LighHead").GetComponent<LightHead>();
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("piwerUp is pecked");
            lightHead.Intensity = 1f;
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("piwerUp is pecked");
            lightHead.Intensity = 1f;
            Destroy(gameObject);
        }
    }

}
