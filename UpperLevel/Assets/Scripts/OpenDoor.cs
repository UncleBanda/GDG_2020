using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject player;
    public bool entrato = false;
    public GameObject porta;


    // Update is called once per frame
    void Update()
    {
        if (entrato == true)
        {
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
}
