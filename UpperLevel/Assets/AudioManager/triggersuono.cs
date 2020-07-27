using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggersuono : MonoBehaviour
{
    public AudioSource riproduci;
    public GameObject principessa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == principessa.name)
        {
            riproduci.Stop();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == principessa.name)
        {
            riproduci.Play();
            UnityEngine.Debug.Log("dgdfg");
        }
    }
}
