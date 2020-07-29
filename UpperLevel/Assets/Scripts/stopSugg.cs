using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopSugg : MonoBehaviour
{
    public GameObject sugg;
    public GameObject release;
    public GameObject sugg2;
    bool att=false;

    // Start is called before the first frame update
    void Start()
    {
        sugg.active = false;
        release.active = false;
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
        if (coso.name == "principessinarig1")
        {
            if (sugg2 != null)
            {
                sugg2.active = true;
            }
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

            if (sugg2 != null)
            {
                sugg2.active = false;
            }
        }
        

    }
}
