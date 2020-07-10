using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverplat : MonoBehaviour
{
    GameObject principessa;
    public Quaternion currentAngle;
    public bool isEntered = false;
    generalLev lever;
    public GameObject connected;
    
    // Start is called before the first frame update
    void Start()
    {
        lever = connected.GetComponent<generalLev>() ;
        principessa = GameObject.Find("principessinarig1");
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, currentAngle, 0.1f);
        if (Input.GetKeyDown(KeyCode.I) && isEntered)
        {
            lever.moveplatf();
           

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
        }
    }
}
