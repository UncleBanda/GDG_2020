using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
//using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMotor : MonoBehaviour
{
    private CharacterController controller;
    private float saltoTime = 1f;
    private bool salta = false;
    public bool grabEngine = false;

    //private float verticalVelocity;
    //private float gravity = 7.0f;

    public float speed = 7f;
    private Rigidbody rb;
    public LayerMask groundLayers;
    public float jumpForce = 9f;
    private BoxCollider col;
    public GameObject Grounded1;
    public GameObject Grounded2;
    public GameObject Grounded3;
    static Animator animator;
    public bool jump = false;
    private bool isGroundedBool;
    public AudioManager audiomanager;



    void Start()
    {
        //controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        col = GetComponent<BoxCollider>();
        UnityEngine.Debug.Log("" + SceneManager.GetActiveScene().buildIndex);
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            FindObjectOfType<AudioManager>().StopPlaying("emo");
            FindObjectOfType<AudioManager>().Play("sofferenza");
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("emo");
            FindObjectOfType<AudioManager>().StopPlaying("sofferenza");
        }

        //setSpheres();
    }

    void Update()
    {
        isGroundedBool = IsGrounded();
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

        if (translation != 0)
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
        if (jump)
        {


            if (rb.velocity.y < 0f && isGroundedBool == true)
            {


                //animator.SetTrigger("atterra");
                jump = false;
                UnityEngine.Debug.Log("asdas");




            }
            // facoltativo, se non piace togliamo
            /* if (rb.velocity.y < 0f )
             {


                 //animator.SetTrigger("atterra");


                 rb.AddForce(Vector3.up * -0.4f, ForceMode.Impulse);



             }*/
        }
        if (Input.GetButtonDown("Jump") && jump == false)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            animator.SetTrigger("isJumping");

            jump = true;

            //UnityEngine.Debug.Log(""+ IsGrounded());


            // salta = true;
        }
        animator.SetBool("Atterra_bool", isGroundedBool);


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

        // if (rb.velocity.y <0f)
        //  {

        UnityEngine.Debug.DrawRay(Grounded1.transform.position, -Vector3.up * 0.25f, Color.yellow);
        UnityEngine.Debug.DrawRay(Grounded2.transform.position, -Vector3.up * 0.25f, Color.yellow);
        UnityEngine.Debug.DrawRay(Grounded3.transform.position, -Vector3.up * 0.25f, Color.yellow);
        //rb.velocity -= Vector3.up * 1.5f;
        RaycastHit hit1;
        RaycastHit hit2;
        RaycastHit hit3;
        int i = 0;


        if (Physics.Raycast(Grounded1.transform.position, -Vector3.up, out hit1, 0.25f))
        {
            i++;


        }
        if (Physics.Raycast(Grounded2.transform.position, -Vector3.up, out hit2, 0.25f))
        {
            i++;


        }
        if (Physics.Raycast(Grounded3.transform.position, -Vector3.up, out hit3, 0.25f))
        {
            i++;


        }
        if (i >= 1)
        {
            i = 0;
            return true;


        }
        else return false;


        // }
        // else return false;
    }

}