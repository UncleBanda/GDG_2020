using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverFin : MonoBehaviour
{
    public int ph;
    GameObject principessa;
    public Quaternion currentAngle;
    public bool isEntered = false;
    GameObject lancetta;
    // Start is called before the first frame update
    void Start()
    {
        ph = 1;
        currentAngle = Quaternion.Euler(0, 0, ph * 45);
        principessa = GameObject.Find("principessinarig1");
        lancetta = GameObject.Find("Rotella (3)");
        Debug.Log("" + principessa.name);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, currentAngle, 0.1f);
        if (Input.GetKeyDown(KeyCode.I) && isEntered)
        {
            ph = ph*-1;
            
            currentAngle = Quaternion.Euler(0, 0, ph * 45);


            

        }

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.name == principessa.name)
        {
            isEntered = true;
            lancetta.GetComponent<lancetta>().SetEntered(isEntered);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == principessa.name)
        {
            isEntered = false;
            lancetta.GetComponent<lancetta>().SetEntered(isEntered);
        }
    }
}
