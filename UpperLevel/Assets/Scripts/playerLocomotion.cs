using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLocomotion : CharacterStateBase
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
   

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float horizontal = Input.GetAxis("Horizontal");
        animator.SetFloat("horizontal", horizontal);
        float translation = horizontal * GetCharacterControl(animator).speed * Time.deltaTime;
        GetCharacterControl(animator).transform.Translate(Vector3.forward * Mathf.Abs(translation));

        //transform.position += -Vector3.forward * translation;
        if (translation != 0)
        {
            animator.SetBool("isMoving", true);
            if (translation < 0)
            {
                GetCharacterControl(animator).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
            else
            {
                GetCharacterControl(animator).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }

        }
        else
        {
            animator.SetBool("isMoving", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("isJumping");
        }
        //anim.SetFloat("Speed", Input.GetAxis("Horizontal"));
        //transform.position += Vector3.forward * Timeout.deltaTime * Input.GetAxis("Horizontal");

    }


    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
    

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
