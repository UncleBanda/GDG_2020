using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidDropCollision : MonoBehaviour
{
    public GameObject player;
    public GameObject drop;
    private Rigidbody rb;
    private Vector3 originalPos;


    // Start is called before the first frame update
    void Start()
    {
        rb = drop.GetComponent<Rigidbody>();
        originalPos = drop.transform.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == drop.name)
        {
            rb.velocity = Vector3.zero;
            drop.transform.localPosition = originalPos;

        }
    }


}
