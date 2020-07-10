using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stallPhase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int phase = GameStatus.GetPhase();
        if (phase != 0)
        {
            transform.Translate(Vector3.forward * (-phase) * 6f);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
