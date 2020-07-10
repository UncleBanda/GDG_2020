using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRespawn : MonoBehaviour
{
    public GameObject player;
    public RespawnPoint respawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            respawn.SetRespawnPoint(gameObject.transform.position);
            Debug.Log("spawner");
        }
    }
}
