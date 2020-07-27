using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trovato : MonoBehaviour
{
    public bool trovato = false;
    public GameObject player;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == player.name)
        {
            trovato = true;
        }
    }
}
