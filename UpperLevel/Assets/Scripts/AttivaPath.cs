using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttivaPath : MonoBehaviour
{
    public GameObject principessa;


    
    void OnTriggerEnter(Collider other)
    {
        if(other.name == principessa.name)
        {
    
            principessa.GetComponent<Follower>().enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == principessa.name)
        {

            principessa.GetComponent<Follower>().enabled = false;
        }
    }
}
