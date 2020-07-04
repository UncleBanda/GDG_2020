using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class costruttiva : MonoBehaviour
{
    AnimationCurve curve;
    Vector3 startPos;
    public float dist = 10f;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        curve = new AnimationCurve(new Keyframe(Time.time, startPos.y));
        curve.preWrapMode = WrapMode.Once;
        curve.postWrapMode = WrapMode.Once;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, curve.Evaluate(Time.time), transform.position.z);
    }

    public void movement(int ph)
    {
        
        Vector3 currPos = new Vector3(transform.position.x, curve.Evaluate(Time.time), transform.position.z);
        if (ph == -1)
        {
            curve = new AnimationCurve(new Keyframe(Time.time, currPos.y), new Keyframe(Time.time + 6f, startPos.y + dist));
        }
        else
        {
            curve = new AnimationCurve(new Keyframe(Time.time, currPos.y), new Keyframe(Time.time + 6f, startPos.y));
        }

        curve.preWrapMode = WrapMode.Once;
        curve.postWrapMode = WrapMode.Once;
        

        
    }
}
