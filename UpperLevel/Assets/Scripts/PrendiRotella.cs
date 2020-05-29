using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrendiRotella : MonoBehaviour
{
    private bool isEntered = false;

    public GameObject principessa;
    public playerMotor playerMotor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isEntered == true)
        {
            if (Input.GetKey(KeyCode.T))
            {
                Destroy(gameObject);
                playerMotor.grabEngine = true;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == principessa.name)
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
