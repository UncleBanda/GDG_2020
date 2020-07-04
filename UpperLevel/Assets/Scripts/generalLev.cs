using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class generalLev : MonoBehaviour
{
    public int state = 1; 
    GameObject principessa;
    public Quaternion currentAngle;
    public bool isEntered = false;
    public GameObject platform;
    //public float speed = 2f;
    public GameObject connected;
    float arr;
    public float dist = 12f;
    public Vector3 startPos;
    AnimationCurve curve;
    // Start is called before the first frame update
    void Start()
    {
        
        currentAngle = Quaternion.Euler(45, -90, 0);
        connected.GetComponent<leverplat>().currentAngle = currentAngle;
        principessa = GameObject.Find("principessinarig1");
       // platform = GameObject.Find("Puzzle_Sliding_Platform_1x1");
        startPos = platform.transform.position;
        curve = new AnimationCurve(new Keyframe(Time.time, startPos.y));
        curve.preWrapMode = WrapMode.Once;
        curve.postWrapMode = WrapMode.Once;
        arr = startPos.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, currentAngle, 0.1f);
        if (Input.GetKeyDown(KeyCode.I) && isEntered)
        {
            moveplatf();
           
        }
        platform.transform.position = new Vector3(platform.transform.position.x, curve.Evaluate(Time.time), platform.transform.position.z);
        
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

    public void moveplatf()
    {
        state = -1 * state;
        arr = arr + state * dist;
        UnityEngine.Debug.Log("" + arr);
        startPos = new Vector3(platform.transform.position.x, curve.Evaluate(Time.time), platform.transform.position.z);
        UnityEngine.Debug.Log("" + startPos.y);

        curve = new AnimationCurve(new Keyframe(Time.time, startPos.y), new Keyframe(Time.time + 6f, arr));
        curve.preWrapMode = WrapMode.Once;
        curve.postWrapMode = WrapMode.Once;

        currentAngle = Quaternion.Euler(state * 45, -90, 0);
        connected.GetComponent<leverplat>().currentAngle = currentAngle;
    }
}
