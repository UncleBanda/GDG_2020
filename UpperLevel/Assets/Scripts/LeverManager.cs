using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour
{
    public GameObject platform;
    public GameObject engine;

    public LeverActivate levaSx;
    public LeverActivateDx levaDx;

    void Update()
    {
        if (levaSx.sx == 1 && levaDx.dx == 1)
        {
            platform.GetComponent<Animator>().enabled = true;
            engine.GetComponent<Animator>().enabled = true;
        }
    }
}
