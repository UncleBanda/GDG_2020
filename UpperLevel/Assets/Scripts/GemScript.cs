using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{

    public GameObject player;

    private bool entrato = false;
    // Update is called once per frame


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
        }
        
    }
}
