using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemmaFinale : MonoBehaviour
{
    public GameObject player;

    private bool entrato = false;
    AudioSource riproduci;
    // Start is called before the first frame update
    void Start()
    {
        riproduci = GameObject.Find("principessinarig1/gemma").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            GameObject.Destroy(gameObject);
            entrato = true;
            GameStatus.SetGem(true);
            
            riproduci.Play();
        }

    }
}
