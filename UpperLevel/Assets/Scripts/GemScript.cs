using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{

    public GameObject player;

    private bool entrato = false;
    AudioSource riproduci;
    // Update is called once per frame

    void Start()
    {
        riproduci = GameObject.Find("principessinarig1/gemma").GetComponent<AudioSource>();

    }

    void Update()
    {
        gameObject.transform.Rotate(0, 90 * Time.deltaTime, 0);
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.name == player.name)
        {
            GameObject.Destroy(gameObject);
            entrato = true;
            Debug.Log("entrato");
            player.GetComponent<PlayerTimeManagement>().GemBonus(1);
            riproduci.Play();
        }
        
    }
}
