using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class platformActive : MonoBehaviour
{
    AnimationCurve curve;
    int lev;
    public float offset = 5f;
    public float speed = 2f;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        lev = GameObject.Find("Platform_lever/Sandstone_5").GetComponent<generalLev>().state;
        UnityEngine.Debug.Log("" +lev);
        startPos = this.transform.position;
        curve = new AnimationCurve(new Keyframe(Time.time, startPos.y), new Keyframe(Time.time + offset, startPos.y + offset));
        curve.preWrapMode = WrapMode.Once;
        curve.postWrapMode = WrapMode.Once;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.N))
        {
            UnityEngine.Debug.Log("ei");
            
            transform.position = new Vector3(transform.position.x, curve.Evaluate(Time.time), transform.position.z);

        }
       


    }
}
