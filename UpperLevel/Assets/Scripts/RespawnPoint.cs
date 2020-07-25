using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System.Diagnostics;
using System.Collections.Specialized;

public class RespawnPoint : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public GameObject p;
    public float time=3;
    public GameObject rotella;
    public GameObject repositionRotella;
    float startTime;
    bool animorte = false;
    private playerMotor motor;
    public CinemachineVirtualCamera virtualCamera;

    void Start()
    {
        startTime = time;
        p = GameObject.Find("principessinarig1");
        motor = p.transform.GetComponent<playerMotor>();
        
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
            virtualCamera.Follow = p.transform;
            motor.enabled = true;
        }

    }

    public void SetRespawnPoint(Vector3 positon)
    {
        respawnPoint.transform.position = positon;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name != rotella.name) { 
        animorte = true;
        motor.enabled = false;
        p.GetComponent<DeathEffect>().Die();

        virtualCamera.Follow = null;
        player.transform.position = respawnPoint.transform.position;
        }
        else
        {
            rotella.transform.position = repositionRotella.transform.position;
            rotella.GetComponent<Rigidbody>().velocity= Vector3.zero;
        }
    }
}
