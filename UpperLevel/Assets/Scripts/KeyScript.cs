﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;

    public GameObject timeManager;
    public int level;
    private bool entered=false;

    // Update is called once per frame
void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);

        if (entered)
        {
            if (Input.KeyDown(Input.KeyCode.I)) { 
            Destroy(gameObject);

            Debug.Log("diomerda");
            timeManager.GetComponent<TimeSceneManager>().SceneChange(level);
        }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            entered = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == player.name)
        {
            entered = false;
        }
    }
}
