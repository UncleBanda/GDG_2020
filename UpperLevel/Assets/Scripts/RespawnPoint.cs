using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RespawnPoint : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public GameObject p;
    public float time=3;
    float startTime;
    bool animorte = false;
    public CinemachineVirtualCamera virtualCamera;

    void Start()
    {
        startTime = time;
        p = GameObject.Find("principessinarig1");
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
        virtualCamera.Follow = null;
        player.transform.position = respawnPoint.transform.position;
    }
}
