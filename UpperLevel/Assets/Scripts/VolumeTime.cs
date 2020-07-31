using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class VolumeTime : MonoBehaviour
{
    public TimeManager timemanager;
    public GameObject filtro;
    private Volume volume;

    void Start()
    {
        volume = filtro.GetComponent<Volume>();
    }
    // Update is called once per frame
    void Update()
    {
        if (timemanager.TimeIsStopped != true)
        {
            volume.enabled = false;
        }
        else
        {
            volume.enabled = true;
        }
    }
}