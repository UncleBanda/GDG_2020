using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class threelev : MonoBehaviour
{
    GameObject principessa;
    public Quaternion currentAngle;
    public bool isEntered = false;
    int ph;
    GameObject acid;
    GameObject stal;
    //public float arr;
    //public float dist = 10f;
    // Start is called before the first frame update
    void Start()
    {
        currentAngle = Quaternion.Euler(ph * 45, -90, 0);
        principessa = GameObject.Find("principessinarig1");
        acid = GameObject.Find("Cubeleva");
        stal = GameObject.Find("Stalattite_piattaforma_New (19)");


    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, currentAngle, 0.1f);
        if (Input.GetKeyDown(KeyCode.I) && isEntered)
        {
            ph += 1;
            if (ph > 1)
            {
                ph = -1;
            }
            currentAngle = Quaternion.Euler(ph * 45, -90, 0);
            acid.GetComponent<downacid>().movement(ph);
            stal.GetComponent<costruttiva>().movement(ph);

            //arr = arr + state * dist;
            //UnityEngine.Debug.Log("" + arr);
            //startPos = new Vector3(platform.transform.position.x, curve.Evaluate(Time.time), platform.transform.position.z);
            //UnityEngine.Debug.Log("" + startPos.y);


        }

        

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
