using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;



public class Potionn1 : MonoBehaviour
{
    int ph;
    GameObject principessa;
    public Quaternion currentAngle;
    public bool isEntered = false;
    private bool arrivato;
    public GameObject sugg;

    public AudioSource riproduci;
    // Start is called before the first frame update
    void Start()
    {
        ph = GameStatus.GetPhase();
        currentAngle = Quaternion.Euler(0, 0, ph * 45);
        principessa = GameObject.Find("principessinarig1");
        sugg.active = false;
        arrivato = GameStatus.GetTrovato();
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, currentAngle, 0.1f);
        if (Input.GetKeyDown(KeyCode.I) && isEntered && arrivato)
        {
            riproduci.Play();
            ph += 1;
            if (ph > 1)
            {
                ph = -1;
            }
            currentAngle = Quaternion.Euler(0, 0, ph * 45);


            GameStatus.SetPhase(ph);

        }
        else if (isEntered && arrivato == false)
        {
            sugg.active = true;
        }
        else
            sugg.active = false;

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.name == principessa.name)
        {
            isEntered = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == principessa.name)
        {
            isEntered = false;
        }
    }

}