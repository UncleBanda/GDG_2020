using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRespawn : MonoBehaviour
{
    public GameObject player;
    public RespawnPoint respawn;
    public string InputNumber;
    public bool hi;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            respawn.SetRespawnPoint(gameObject.transform.position);
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
