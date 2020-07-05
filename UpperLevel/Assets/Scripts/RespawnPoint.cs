using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    
  
    public void SetRespawnPoint(Vector3 positon)
    {
        respawnPoint.transform.position = positon;
    }
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.Debug.Log("fdsf");
        player.transform.position = respawnPoint.transform.position;
    }
}
