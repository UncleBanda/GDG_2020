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

    void Start()
    {
        startPos = this.transform.position;
        arrivo = startPos.y + offset;
        if (x)
        {
            curve = new AnimationCurve(new Keyframe(0, startPos.x), new Keyframe(offset, startPos.x + offset));
        }
        if (y)
        {
            curve = new AnimationCurve(new Keyframe(0, startPos.y), new Keyframe(offset, arrivo));
        }
        //curve = new AnimationCurve(new Keyframe(0, startPos.y), new Keyframe(offset, startPos.y + offset));
        curve.preWrapMode = WrapMode.PingPong;
        curve.postWrapMode = WrapMode.PingPong;
    }

    void OnAwake()
    {
        UnityEngine.Debug.Log("dsd");
    }

    void Update()
    {
       
        if (x)
        {
            transform.position = new Vector3(curve.Evaluate(Time.time), transform.position.y, transform.position.z);
        }

        if (y)
        {
            transform.position = new Vector3(transform.position.x, curve.Evaluate(Time.time), transform.position.z);
        }
      
    }


}
