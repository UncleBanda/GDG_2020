using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class stop : MonoBehaviour
{
    animCurve script;
    // Start is called before the first frame update
    void Start()
    {
        script = GetComponent<animCurve>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            
            if (script.enabled == true)
            {
               script.enabled = false;
            }
            else 
            {
               script.enabled = true;
            }

        }
    }
}
