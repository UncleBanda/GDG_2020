using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnRotella : MonoBehaviour
{

    public GameObject respawn;
    public GameObject rotella;
    // Start is called before the first frame update
  

    void onTriggerEnter(Collider other)
    {
        if(other.name == rotella.name)
        {
            rotella.transform.position = respawn.transform.position;
        }
    }
}
