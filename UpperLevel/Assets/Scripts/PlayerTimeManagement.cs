﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTimeManagement : MonoBehaviour
{
    // Start is called before the first frame update
    private TimeManager timemanager;
    public AbilityBar abilityBar;
    static public float maxAbilityValue = 10; //static perchè cosi viene salvato di scena in scen e non si resetta
    static public float currentAbilityValue;


    // Start is called before the first frame update
    void Start()
    {
        timemanager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
        currentAbilityValue = maxAbilityValue;
        abilityBar.SetMaxValue(maxAbilityValue);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) //Stop Time when Q is pressed
        {
            if (currentAbilityValue > 0)
            {
                timemanager.StopTime();

            }

        }
        if (Input.GetKeyDown(KeyCode.E) && timemanager.TimeIsStopped)  //Continue Time when E is pressed
        {
            timemanager.ContinueTime();


        }

        if (timemanager.TimeIsStopped)
        {
            if (currentAbilityValue > 0)
            {
                currentAbilityValue -= Time.deltaTime;
                abilityBar.SetValue(currentAbilityValue);
            }
            else
            {
                currentAbilityValue = 0;

                timemanager.ContinueTime();

            }
        }
    }
}
