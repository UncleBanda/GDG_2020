using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPuzzleManager : MonoBehaviour
{
    public BigR BigR;
    public GameObject platform;
    public GameObject sxRot;
    public GameObject dxRot;

    public FinalPuzzle levaSx;
    public FinalPuzzle_Dx levaDx;

    void Update()
    {
        if (levaSx.sx == 1 && levaDx.dx == 1)
        {
            BigR.isMoving= true;
            platform.GetComponent<Animator>().enabled = true;
            sxRot.GetComponent<Animator>().enabled = true;
            dxRot.GetComponent<Animator>().enabled = true;
        }

        if (levaSx.sx == 1)
        {
            sxRot.GetComponent<Animator>().enabled = true;
        }
        else
        {
            sxRot.GetComponent<Animator>().enabled = false;
        }

        if (levaDx.dx == 1)
        {
            dxRot.GetComponent<Animator>().enabled = true;
        }
        else
        {
            dxRot.GetComponent<Animator>().enabled = false;
        }
    }
}
