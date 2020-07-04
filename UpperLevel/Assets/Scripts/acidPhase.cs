using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class acidPhase : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        int phase = GameStatus.GetPhase();
        if (phase != 0)
        {
            transform.Translate(Vector3.up * phase* 3f);
           
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
