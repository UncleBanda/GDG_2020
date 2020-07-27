using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRespawn : MonoBehaviour
{
    public GameObject player;
    public GameObject respawnPoint;
    public string InputNumber;

    void Start() {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
           respawnPoint.transform.position = this.gameObject.transform.position;
            Debug.Log("spawner");
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(InputNumber))
        {
            player.transform.position = gameObject.transform.position;
        }
    }
}
