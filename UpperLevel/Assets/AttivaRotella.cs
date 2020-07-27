using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttivaRotella : MonoBehaviour
{
    public GameObject player;
    //public GameObject levaUp;
    //public GameObject levaMiddle;
    //public GameObject levaDown;

    public Rigidbody rotella;

    bool isInside = false;

    public AudioSource riproduci;
    void Update()
    {
        if (isInside == true)
        {
            if (Input.GetKey(KeyCode.I))
            {
                //levaUp.GetComponent<Animator>().enabled = true;
                //levaMiddle.GetComponent<Animator>().enabled = true;
                //levaDown.GetComponent<Animator>().enabled = true;

                rotella.constraints &= ~RigidbodyConstraints.FreezePositionY;
                riproduci.Play();
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            isInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == player.name)
        {
            isInside = false;
        }
    }
}