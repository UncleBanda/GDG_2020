﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverActivate : MonoBehaviour
{
    public GameObject player;
    private TimeManager timemanager;
    public GameObject levaUp;
    public GameObject levaMiddle;
    public GameObject levaDown;
    public LeverActivateDx dx;



    private bool isInside = false;
    private bool start = false;
    public float timer = 1.5f;

    public int sx = 0;
    public AudioSource riproduci;
    public AudioSource inceppato;

    void Start()
    {
        timemanager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();

    }

    void Update()
    {
        if(isInside == true)
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
                sx = 1;
                start = true;

            }
        }

        if (timemanager.TimeIsStopped == false && start == true)
        {
            timer -= Time.deltaTime;
        }

     
        if (timer < 0&& dx.dx!=1)
        {
            sx = 0;
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
