using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaivor : MonoBehaviour
{
    [SerializeField] float camOffset;
    private GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");                
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, camOffset);
    }
}
