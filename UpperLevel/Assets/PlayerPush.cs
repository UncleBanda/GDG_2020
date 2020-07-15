using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour
{
    public float pushStrength = 6.0f;
    private playerMotor pm;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        if (body == null || body.isKinematic)
        {
            return;
        }

        pushStrength = pm.speed;

        Vector3 direction = new Vector3(hit.moveDirection.x, 0, 0);

        body.velocity = direction * pushStrength;
    }

    void Start()
    {
        pm = gameObject.GetComponent<playerMotor>();
    }
}