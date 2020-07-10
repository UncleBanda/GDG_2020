using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class movingplatform : MonoBehaviour
{
    Vector3 startPos;
    public float speed=2f;
    public float distance = 6f;
    public bool x = false;
    public bool y = false;
    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (y)
        {
            transform.position = new Vector3(transform.position.x, startPos.y + Mathf.PingPong(Time.time, distance), transform.position.z);
        }
        if (x)
        {
            transform.position = new Vector3 (startPos.x + Mathf.PingPong(Time.time, distance), transform.position.y, transform.position.z);
        }
    }
}
