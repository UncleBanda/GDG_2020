using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    private SphereCollider col;

    static Animator animator;
      

    void Start()
    {
        //controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        animator.SetFloat("horizontal", horizontal);
        float translation = horizontal * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * Mathf.Abs(translation));

        if (salta == true)
        {
            saltoTime -= Time.deltaTime;
        }

        if (saltoTime < 0)
        {
            salta = false;
            saltoTime = 1f;
        }

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

        if (Input.GetButtonDown("Jump")  && IsGrounded() && salta==false)
        {
            animator.SetTrigger("isJumping");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            salta = true;
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

    private bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius*9f, groundLayers);
            }
}
