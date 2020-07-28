using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject player;
    public bool entrato = false;
    public GameObject porta;
    public GameObject sugg;

    void Start()
    {
        sugg.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (entrato == true)
        {
            if (GameStatus.GetRaccolta() == true && Input.GetKeyDown(KeyCode.I))
            {
                porta.GetComponent<Animator>().enabled = true;
            }
            else
            {
                sugg.active = true;
            }
            
            //if (chiave == true && premo pulsante I){ porta.GetComponent<Animator>.enabled=true; }
            //else {"Mi disp non hai la chiave"}
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            entrato = true;

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == player.name)
        {
            entrato = false;
            sugg.active = false;
        }
    }
}
