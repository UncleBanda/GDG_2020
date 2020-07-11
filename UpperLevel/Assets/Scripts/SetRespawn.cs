using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRespawn : MonoBehaviour
{

    public GameObject spawnPoint;
    public GameObject player;




    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            spawnPoint.transform.position = this.transform.position;
            Destroy(this);
        }


    }
    
}
