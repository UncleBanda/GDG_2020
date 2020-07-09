using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public GameObject p;
    public float time=3;
    float startTime;
    bool animorte = false;

    void Start()
    {
        startTime = time;        
    }
    void Update()
    {
        if (animorte)
        {
            time -= Time.deltaTime;
        }
        if (time < 0)
        {

            animorte = false;
            time = startTime;
            //player.transform.position = respawnPoint.transform.position;
        }

    }

    public void SetRespawnPoint(Vector3 positon)
    {
        respawnPoint.transform.position = positon;
    }
    private void OnTriggerEnter(Collider other)
    {
        animorte = true;
        p.GetComponent<DeathEffect>().Die();
        player.transform.position = respawnPoint.transform.position;
    }
}
