using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    static Animator animator;
    private Collider coll;

    public float speed = 8f;

 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        coll = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        animator.SetFloat("horizontal", horizontal);
        float translation = horizontal * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * Mathf.Abs(translation));

        
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

        if (Input.GetButtonDown("Jump"))
        {
			if (IsGrounded())
			{
				animator.SetTrigger("isJumping");
			}
        }
        //anim.SetFloat("Speed", Input.GetAxis("Horizontal"));
        //transform.position += Vector3.forward * Timeout.deltaTime * Input.GetAxis("Horizontal");
    }

    //metthod that will look below our character and see if there is a collider
    public bool IsGrounded()
	{
        return Physics.Raycast(transform.position, Vector3.down, coll.bounds.extents.y + 0.1f);
	}
}
