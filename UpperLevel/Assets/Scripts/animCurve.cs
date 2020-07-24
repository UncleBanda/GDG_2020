using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class animCurve : MonoBehaviour
{
    public AnimationCurve curve;
    public float offset = 5f;
    Vector3 startPos;
    float arrivo;
    public bool x = false;
    public bool y = false;
    public float speed = 1f;
    private float valoreTempo = 0f;
    private TimeManager timemanager;
    public bool invert=false;

    void Start()
    {
        timemanager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
        startPos = this.transform.position;
        if (invert == false) {
            arrivo = startPos.y + offset;
        }
        else
        {
            arrivo = startPos.y - offset;
        }
        
        
        if (x)
        {
            curve = new AnimationCurve(new Keyframe(0, startPos.x), new Keyframe(offset / speed, startPos.x + offset));
        }
        if (y)
        {
            curve = new AnimationCurve(new Keyframe(0, startPos.y), new Keyframe(offset / speed, arrivo));
        }
        //curve = new AnimationCurve(new Keyframe(0, startPos.y), new Keyframe(offset, startPos.y + offset));
        curve.preWrapMode = WrapMode.PingPong;
        curve.postWrapMode = WrapMode.PingPong;
    }

    /* void OnAwake()
     {
         UnityEngine.Debug.Log("dsd");
     }*/

    void Update()
    {
        if (timemanager.TimeIsStopped == false)
        {
            valoreTempo += Time.deltaTime;
        }
        if (x)
        {
            transform.position = new Vector3(curve.Evaluate(valoreTempo), transform.position.y, transform.position.z);
        }

        if (y)
        {
            transform.position = new Vector3(transform.position.x, curve.Evaluate(valoreTempo), transform.position.z);
        }

    }


}
