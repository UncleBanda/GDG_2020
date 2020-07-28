using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suggerimento : MonoBehaviour
{
    public GameObject sugg;
    public GameObject sugg2;

    // Start is called before the first frame update
    void Start()
    {
        sugg.active = false;
        if (sugg2 != null)
        {
            sugg2.active = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider coso)
    { 
        if(coso.name == "principessinarig1")
        {
            sugg.active = true;
            if (sugg2 != null)
            {
                sugg2.active = true;
            }
            
            UnityEngine.Debug.Log("entrato");
        }
        
    }

    void OnTriggerExit(Collider coso)
    {

        if (coso.name == "principessinarig1")
        {
            sugg.active = false;
            if (sugg2 != null)
            {
                sugg2.active = false;
            }

            UnityEngine.Debug.Log("uscito");
        }

    }
}
