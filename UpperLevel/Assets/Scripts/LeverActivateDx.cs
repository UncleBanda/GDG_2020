using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverActivateDx : MonoBehaviour
{
    public GameObject player;
    private TimeManager timemanager;
    public GameObject levaUp;
    public GameObject levaMiddle;
    public GameObject levaDown;
    public LeverActivate sx;

    private bool isInside = false;
    private bool start = false;

    public int dx = 0;
    public float timer = 1.5f;

    public AudioSource riproduci;
    public AudioSource inceppato;

    private void Start()
    {
        timemanager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
    }

    void Update()
    {
        if (isInside == true)
        {
            if (Input.GetKey(KeyCode.I))
            {
                levaUp.GetComponent<Animator>().enabled = true;
                levaUp.GetComponent<Animator>().SetBool("TimeEnded", false);
                levaMiddle.GetComponent<Animator>().enabled = true;
                levaMiddle.GetComponent<Animator>().SetBool("TimeEnded", false);
                levaDown.GetComponent<Animator>().enabled = true;
                levaDown.GetComponent<Animator>().SetBool("TimeEnded", false);
                riproduci.Play();
                dx = 1;
                start = true;

           
            }
        }

        if (timemanager.TimeIsStopped == false && start == true)
        {
            timer -= Time.deltaTime;
        }

        if (timer < 0 && sx.sx !=1)
        {
            dx = 0;
            timer = 1.5f;
            start = false;

            levaUp.GetComponent<Animator>().SetBool("TimeEnded", true);
            levaMiddle.GetComponent<Animator>().SetBool("TimeEnded", true);
            levaDown.GetComponent<Animator>().SetBool("TimeEnded", true);
            inceppato.Play();
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

