using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewRespawn : MonoBehaviour
{
    public GameObject player;
    public GameObject respawnPoint;
    public string InputNumber;

    void Start() {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (GameStatus.GetRespDown() != Vector3.zero)
            {
                UnityEngine.Debug.Log("setdown" + GameStatus.GetRespDown());
                respawnPoint.transform.position = GameStatus.GetRespDown();
                player.transform.position = respawnPoint.transform.position;
            }
        }
        else if (GameStatus.GetRespUp() != Vector3.zero)
        {
            UnityEngine.Debug.Log("setup" + GameStatus.GetRespUp());
            respawnPoint.transform.position = GameStatus.GetRespUp();
            player.transform.position = respawnPoint.transform.position;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            UnityEngine.Debug.Log("egg");
            respawnPoint.transform.position = this.gameObject.transform.position;
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                GameStatus.SetRespDown(this.transform.position);
                UnityEngine.Debug.Log("down" + GameStatus.GetRespDown());
            }
            else
            {
                GameStatus.SetRespUp(this.transform.position);
                UnityEngine.Debug.Log("up" + GameStatus.GetRespUp());
            }
            
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
