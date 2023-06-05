using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{

    [SerializeField] float speed;


    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0f, 0.0f, -speed * Time.deltaTime, Space.Self);
    }
}
