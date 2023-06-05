using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChController : MonoBehaviour
{
    [SerializeField] CharacterController charController;
    [SerializeField] float movementSpeed;
    [SerializeField] float gravityValue;
    [SerializeField] float jumpHeight;
    private float HorInput;    
    private Vector3 playerVelocity;
    public float MovementSpeed
    {
        get
        {
            return movementSpeed;
        }
        set
        {
            movementSpeed = value;
        }
    }
    public float JumpHeight
    {
        get
        {
            return jumpHeight;
        }
        set
        {
            jumpHeight = value;
        }
    }
    public float GravityValue
    {
        get
        {
            return gravityValue;
        }
        set
        {
            gravityValue = value;
        }
    }


    void Start()
    {
        charController = gameObject.GetComponent<CharacterController>();        
    }

    // Update is called once per frame
    private void Update()
    {
        HorInput = Input.GetAxis("Horizontal");      
        playerVelocity.y += gravityValue * Time.deltaTime; 
        charController.Move(playerVelocity * Time.deltaTime); // gravitation effect

        Movement(playerVelocity.y);

        if (Input.GetButton("Jump") && charController.isGrounded)
        {
            Jump();
        }
    }

    private void Movement(float gravity)
    {
        Vector3 move = new Vector3(HorInput, gravity, 0);
        charController.Move(move * Time.deltaTime * movementSpeed);
    }
    private void Jump()
    {
        playerVelocity.y = jumpHeight;
    }
}
