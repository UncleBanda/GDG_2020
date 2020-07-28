using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doppio : MonoBehaviour
{
    public GameObject sugg;
    public GameObject erim;
    private GameObject principessa;
    public bool isEntered;
    // Start is called before the first frame update
    void Start()
    {
        principessa = GameObject.Find("principessinarig1");
        sugg.active = false;
        erim.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && isEntered && sugg.active == false && erim.active ==false)
        {
            sugg.active = true;
            UnityEngine.Debug.Log("sdfdsfs");

        }
        else if (Input.GetKeyDown(KeyCode.I) && isEntered && sugg.active == true && erim.active ==false)
        {
            sugg.active = false;
            erim.active = true;
        }
        else if (Input.GetKeyDown(KeyCode.I) && sugg.active == false && erim.active == true)
        {
            sugg.active = false;
            erim.active = false;
        }

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.name == principessa.name)
        {
            isEntered = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == principessa.name)
        {
            isEntered = false;
            sugg.active = false;
            erim.active = false;
        }
    }
}
