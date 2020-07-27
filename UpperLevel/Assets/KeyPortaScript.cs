using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPortaScript : MonoBehaviour
{

    public GameObject player;
    public bool chiaveRaccolta = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 90 * Time.deltaTime, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            GameObject.Destroy(gameObject);
            chiaveRaccolta = true;
            GameStatus.SetRaccolta(chiaveRaccolta);

        }

    }
}
