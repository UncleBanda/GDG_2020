using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsActivate : MonoBehaviour
{

    public GameObject rotellaColonna;
    public GameObject levaUp;
    public GameObject levaMiddle;
    public GameObject stairs1;
    public GameObject stairs2;
    public GameObject stairs3;
    public GameObject collider;
    public GameObject rotella;
    public GameObject p;
    private bool isEntered;
    public AudioSource riproduci;

    void Update()
    {
        if (isEntered == true)
        {

            rotellaColonna.SetActive(true);
            Destroy(rotella);

            if (Input.GetKey(KeyCode.I))
            {

                levaUp.GetComponent<Animator>().enabled = true;
                levaMiddle.GetComponent<Animator>().enabled = true;


                stairs1.GetComponent<Animator>().enabled = true;
                stairs2.GetComponent<Animator>().enabled = true;
                stairs3.GetComponent<Animator>().enabled = true;
                Destroy(collider);

                riproduci.Play();

            }

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == p.name && isEntered==false)
        {
            //mostra suggerimento: "Ti serve qualcoisa per azionare il meccanismo"
        }
        if (other.name == rotella.name)
        {
            isEntered = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.name == p.name)
        {
            //nascondi il suggerimento
        }
       
    }
}