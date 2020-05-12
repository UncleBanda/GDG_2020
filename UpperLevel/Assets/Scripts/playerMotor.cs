using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMotor : MonoBehaviour
{
    private CharacterController controller;

    private float verticalVelocity;
    private float gravity = 7.0f;
    private float jumpForce = 3.5f;

  

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
      if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }


        Vector3 moveVector = Vector3.zero;
        moveVector.y = verticalVelocity;
        moveVector.x = Input.GetAxis("Horizontal") * 8f;

        controller.Move(moveVector*Time.deltaTime);
    }
}
