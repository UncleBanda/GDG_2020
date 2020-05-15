using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttivaPath : MonoBehaviour
{
    public GameObject principessa;
    public float time = 5f;
    private bool start = false;

    void Update()
    {
        if(start == true)
        {
            time -= Time.deltaTime;
        }

        if(time < 0)
        {
            start = false;
            principessa.GetComponent<Follower>().enabled = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == principessa.name)
        {
            start = true;
            principessa.GetComponent<Follower>().enabled = true;
        }
    }
}
