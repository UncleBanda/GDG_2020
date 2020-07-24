using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SetRespawn : MonoBehaviour
{

    public GameObject spawnPoint;
    public GameObject player;

    void Start()
    {

        
        if (GameStatus.GetRespDown() != Vector3.zero)
        {
            UnityEngine.Debug.Log("ciao");
            spawnPoint.transform.position = GameStatus.GetRespDown();
            player.transform.position = spawnPoint.transform.position;
        }
         
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            UnityEngine.Debug.Log("egg");
            spawnPoint.transform.position = this.transform.position;
            GameStatus.SetRespDown(this.transform.position);
            UnityEngine.Debug.Log("" + GameStatus.GetRespDown());
            Destroy(this);
        }


    }
    
}
