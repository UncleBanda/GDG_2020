using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

public class playerMotor : MonoBehaviour
{
    private CharacterController controller;
    private float saltoTime=1f;
    private bool salta=false;
    public bool grabEngine = false;

    //private float verticalVelocity;
    //private float gravity = 7.0f;
    
    public float speed = 7f;
    private Rigidbody rb;
    public LayerMask groundLayers;
    public float jumpForce = 7f;
    private BoxCollider col;
    public GameObject Grounded;
    static Animator animator;
    public bool jump= false;
  
      
                
    void Start()
    {
        //controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        col = GetComponent<BoxCollider>();
        //setSpheres();
    }

    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");

        animator.SetFloat("horizontal", horizontal);
        float translation = horizontal * speed * Time.deltaTime;
        
        transform.Translate(Vector3.forward * Mathf.Abs(translation));

       /* if (salta == true)
        {
            saltoTime -= Time.deltaTime;
        }

        if (saltoTime < 0)
        {
            salta = false;
            saltoTime = 1f;
        }*/

        // da considerare per miglioramenti al movimento
        //rb.AddForce(Vector3.forward * horizontal * speed);

        if (translation != 0 )
        {
            animator.SetBool("isMoving", true);
            if (translation < 0)
            {
                transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            }

        }
        else
        {
            animator.SetBool("isMoving", false);
        }

        if (Input.GetButtonDown("Jump") && jump ==false )
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            animator.SetTrigger("isJumping");
            
            jump = true;
            //UnityEngine.Debug.Log(""+ IsGrounded());
            
           
           // salta = true;
        }

        if (jump)
        {
            if (IsGrounded()==true)
            {
                
                
                animator.SetTrigger("atterra");
                jump = false;
            }
        }
        //parte vecchia con il character controller 
        /*if (controller.isGrounded)
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
        //moveVector.x = horizontal * speed;

        controller.Move(moveVector*Time.deltaTime);*/
    }

  

    public bool IsGrounded()
    {
        if (rb.velocity.y <0f)
        {
            
           
            //rb.velocity -= Vector3.up * 1.5f;
            RaycastHit hit1;
            RaycastHit hit2;
            RaycastHit hit3;
            int i=0;

            if (Physics.Raycast(Grounded.transform.position, -Vector3.up, out hit1, 1f)==true)
            {
                i ++;
               
            }
            if (Physics.Raycast(Grounded.transform.position, -Vector3.up, out hit2, 1f) == true)
            {
                i++;

            }
            if (Physics.Raycast(Grounded.transform.position, -Vector3.up, out hit3, 1f) == true)
            {
                i++;

            }

            if (i > 1)
            {
                return true;
            }
        }
        else return false;
    }
    
}
