using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogo : MonoBehaviour
{
    public GameObject sugg;
    private GameObject principessa;
    public bool isEntered;
    // Start is called before the first frame update
    void Start()
    {
        principessa = GameObject.Find("principessinarig1");
        sugg.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && isEntered && sugg.active == false)
        {
            sugg.active = true;
            UnityEngine.Debug.Log("sdfdsfs");

        }
        else if (Input.GetKeyDown(KeyCode.I) && sugg.active == true)
        {
            sugg.active = false;
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
        }
    }
}
