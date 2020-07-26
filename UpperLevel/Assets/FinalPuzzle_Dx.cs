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
            if (Input.GetKey(KeyCode.I))
            {
                //parte animazione
                dx = 1;
                start = true;

            }
        }

        if (timemanager.TimeIsStopped == false && start == true)
        {
            timer -= Time.deltaTime;
        }

        if (timer < 0)
        {
            dx = 0;
            timer = 1.5f;
            start = false;

            //finisce animazione
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
