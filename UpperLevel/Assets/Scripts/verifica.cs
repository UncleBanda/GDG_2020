using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verifica : MonoBehaviour
{
    private bool entered = false;
    public GameObject sugg;
    public GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        sugg.active = false;
        win.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameStatus.GetPuzzle() && GameStatus.GetGem() && entered)
        {
            //fine
            win.active = true;
        }
        else if (GameStatus.GetPuzzle() && GameStatus.GetGem() == false && entered)
        {
            sugg.active = true;
            UnityEngine.Debug.Log("prendi gemma");
        }
    }

    void OnTriggerStay(Collider coso)
    {
        entered = true;
     
    }

    void OnTriggerExit(Collider coso)
    {

        sugg.active = false;
        entered = false;

    }
}
