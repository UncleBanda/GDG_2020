using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopSugg : MonoBehaviour
{
    public GameObject sugg;
    public GameObject release;
    bool att=false;

    // Start is called before the first frame update
    void Start()
    {
        sugg.active = false;
        release.active = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider coso)
    {
        if (coso.name == "principessinarig1")
        {
            if (att == false)
            {
               sugg.active = true;
            }
            
            UnityEngine.Debug.Log("entrato");
            if (Input.GetKeyDown(KeyCode.O) && att==false)
            {
                sugg.active = false;
                release.active = true;
                att = true;

            }
            else if(Input.GetKeyDown(KeyCode.O) && att == true)
            {
                sugg.active = false;
                release.active = false;
                //att = false;
            }
        }

    }

    void OnTriggerExit(Collider coso)
    {

        if (coso.name == "principessinarig1")
        {
            sugg.active = false;
            release.active = false;
            UnityEngine.Debug.Log("uscito");
        }

    }
}
