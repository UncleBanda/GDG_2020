using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPuzzle : MonoBehaviour
{
    public GameObject player;
    private bool entered=false;
    private TimeManager timemanager;
    private bool start = false;
    public float timer = 1.5f;
    public int sx = 0;
    public GameObject leva1;
    public GameObject leva2;
    public FinalPuzzle_Dx levaDx;

    // Start is called before the first frame update
    void Start()
    {
        timemanager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (entered == true)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {


                Ingranaggio();

                

            }
        }
        if (sx == 1 && levaDx.dx == 1)
        {
            start = false;
        }
        else if (sx == 1 && levaDx.dx != 1)
        {
            start = true;
        }

        if (timemanager.TimeIsStopped == false && start == true)
        {
            timer -= Time.deltaTime;
        }

        if (timer < 0)
        {
            sx = 0;
            timer = 1.5f;
            start = false;

            //finisce animazione
            leva1.GetComponent<Animator>().SetBool("TimeEnded", true);
            leva2.GetComponent<Animator>().SetBool("TimeEnded", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == player.name)
        {
            entered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == player.name)
        {
            entered = false;
        }
    }

    void Ingranaggio()
    {
        if (sx == 0)
        {
            sx = 1;


            leva1.GetComponent<Animator>().enabled = true;
            leva1.GetComponent<Animator>().SetBool("TimeEnded", false);
            leva2.GetComponent<Animator>().enabled = true;
            leva2.GetComponent<Animator>().SetBool("TimeEnded", false);
        }else{        
            leva1.GetComponent<Animator>().SetBool("TimeEnded", true);
            leva2.GetComponent<Animator>().SetBool("TimeEnded", true);
            sx = 0;
            timer = 1.5f;
            start = false;
        }

    }
}
