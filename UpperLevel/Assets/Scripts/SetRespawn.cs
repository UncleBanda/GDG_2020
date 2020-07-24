using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRespawn : MonoBehaviour
{

    public GameObject spawnPoint;
    public GameObject player;

    void Start()
    {
        if(GameStatus.GetRespDown() != null)
        {
            spawnPoint.transform.position = GameStatus.GetRespDown().position;
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
            spawnPoint.transform.position = this.transform.position;
            GameStatus.SetRespDown(this.transform);
            Destroy(this);
        }


    }
    
}
