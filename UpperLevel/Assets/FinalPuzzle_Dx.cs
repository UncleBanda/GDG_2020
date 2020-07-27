using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPuzzle_Dx : MonoBehaviour
{
    public GameObject player;
    private bool entered = false;
    private TimeManager timemanager;
    private bool start = false;
    public float timer = 1.5f;
    public int dx = 0;
    public GameObject leva1;
    public GameObject leva2;
    public FinalPuzzle levaSx;


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
        if (dx == 1 && levaSx.sx == 1)
        {
            start = false;
        }
        else if (dx == 1 && levaSx.sx != 1)
        {
            start = true;
        }

        if (timemanager.TimeIsStopped == false && start == true)
        {
            timer -= Time.deltaTime;
        }

        if (timer < 0 )
        {
            dx = 0;
            timer = 1.5f;
            start = false;

            //resetta animazione
            leva1.GetComponent<Animator>().SetBool("TimeEnded", true);
            leva2.GetComponent<Animator>().SetBool("TimeEnded", true);
        }

      
    }


    void Ingranaggio()
    {
        if (dx == 0)
        {
            dx = 1;

            leva1.GetComponent<Animator>().enabled = true;
            leva1.GetComponent<Animator>().SetBool("TimeEnded", false);
            leva2.GetComponent<Animator>().enabled = true;
            leva2.GetComponent<Animator>().SetBool("TimeEnded", false);
        }
        else
        {
            leva1.GetComponent<Animator>().SetBool("TimeEnded", true);
            leva2.GetComponent<Animator>().SetBool("TimeEnded", true);
            dx = 0;
            timer = 1.5f;
            start = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
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
}
