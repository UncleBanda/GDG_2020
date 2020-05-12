using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMotor : MonoBehaviour
{
    private CharacterControl controller;

    private float verticalVelocity;
    private float gravity = 7.0f;
    private float jumpForce = 3.5f;

  

    void Start()
    {
        controller = GetComponent<CharacterControl>();
    }

    void Update()
    {
      if (controller.IsGrounded())
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

        controller.MoveUp(moveVector);
    }
}
