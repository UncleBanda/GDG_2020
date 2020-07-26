using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuggGem : MonoBehaviour
{
    public GameObject sugg;

    // Start is called before the first frame update
    void Start()
    {
        sugg.active = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider coso)
    {
        if (coso.name == "principessinarig1")
        {
            sugg.active = true;
            UnityEngine.Debug.Log("entrato");
        }

    }

    void OnTriggerExit(Collider coso)
    {

        if (coso.name == "principessinarig1")
        {
            sugg.active = false;
            UnityEngine.Debug.Log("entrato");
        }

    }
}