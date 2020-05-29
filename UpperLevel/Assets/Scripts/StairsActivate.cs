using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsActivate : MonoBehaviour { 

    public GameObject principessa;
    public GameObject rotellaColonna;
    public GameObject levaUp;
    public GameObject levaMiddle;
    public GameObject stairs1;
    public GameObject stairs2;
    public GameObject stairs3;

    public playerMotor playerMotor;

    private bool isEntered = false;

    void Update()
    {
        if (isEntered == true)
        {
            if (Input.GetKey(KeyCode.P) && playerMotor.grabEngine == true)
            {
                levaUp.GetComponent<Animator>().enabled = true;
                levaMiddle.GetComponent<Animator>().enabled = true;
        

                stairs1.GetComponent<Animator>().enabled = true;
                stairs2.GetComponent<Animator>().enabled = true;
                stairs3.GetComponent<Animator>().enabled = true;

                rotellaColonna.SetActive(true);

                playerMotor.grabEngine = false;
            }

           /* if (Input.GetKey(KeyCode.T) && playerMotor.grabEngine == false)
            {
                playerMotor.grabEngine = true;
                rotellaColonna.SetActive(false);
            }*/
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == principessa.name)
        {
            isEntered = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == principessa.name)
        {
            isEntered = false;
        }
    }
}
