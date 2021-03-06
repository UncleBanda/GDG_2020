﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTimeManagement : MonoBehaviour
{
    // Start is called before the first frame update
    private TimeManager timemanager;
    public AbilityBar abilityBar;
    public float maxAbilityValue; //static perchè cosi viene salvato di scena in scen e non si resetta
    public float currentAbilityValue;

    public GameObject Background1;
    public GameObject Background2;
    public GameObject FillArea;
    public GameObject filtro;
    public AudioSource riproduci;

    // Start is called before the first frame update
    void Start()
    {
        timemanager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
        maxAbilityValue = GameStatus.GetMaxAbility();
        currentAbilityValue = maxAbilityValue;
        abilityBar.SetMaxValue(maxAbilityValue);
        abilityBar.SetValue(currentAbilityValue);
        UnityEngine.Debug.Log("" + maxAbilityValue);
        float scale = maxAbilityValue / 10;
        Background1.gameObject.transform.localScale = new Vector3(scale, 1f, 1f);
        Background2.gameObject.transform.localScale = new Vector3(scale, 1f, 1f);
        FillArea.gameObject.transform.localScale = new Vector3(scale, 1f, 1f);
    }                                                                                                                                                                        
      public void GemBonus(int value)                                                                                                                                        
    {
        if (maxAbilityValue < 19 && maxAbilityValue>4)
        {
            maxAbilityValue = maxAbilityValue + (3) * value;
            GameStatus.SetMaxAbility(maxAbilityValue);                                                                                                                         
            UnityEngine.Debug.Log("" + maxAbilityValue);
            abilityBar.SetMaxValue(maxAbilityValue);
            currentAbilityValue = maxAbilityValue;

            Background1.gameObject.transform.localScale += new Vector3(0.3f * value, 0f, 0f);
            Background2.gameObject.transform.localScale += new Vector3(0.3f * value, 0f, 0f);
            FillArea.gameObject.transform.localScale += new Vector3(0.3f * value, 0f, 0f);
        }
            if(maxAbilityValue <= 4 && value > 0)
        {
            maxAbilityValue = maxAbilityValue + (3) * value;
            GameStatus.SetMaxAbility(maxAbilityValue);                                                                                                                         
            UnityEngine.Debug.Log("" + maxAbilityValue);
            abilityBar.SetMaxValue(maxAbilityValue);
            currentAbilityValue = maxAbilityValue;

            Background1.gameObject.transform.localScale += new Vector3(0.3f * value, 0f, 0f);
            Background2.gameObject.transform.localScale += new Vector3(0.3f * value, 0f, 0f);
            FillArea.gameObject.transform.localScale += new Vector3(0.3f * value, 0f, 0f);
        }

        if (maxAbilityValue >= 19 && value < 0)
        {
            maxAbilityValue = maxAbilityValue + (3) * value;
            GameStatus.SetMaxAbility(maxAbilityValue);                                                                                                                         
            UnityEngine.Debug.Log("" + maxAbilityValue);
            abilityBar.SetMaxValue(maxAbilityValue);
            currentAbilityValue = maxAbilityValue;

            Background1.gameObject.transform.localScale += new Vector3(0.3f * value, 0f, 0f);
            Background2.gameObject.transform.localScale += new Vector3(0.3f * value, 0f, 0f);
            FillArea.gameObject.transform.localScale += new Vector3(0.3f * value, 0f, 0f);
        }
    }

   
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.O))
        {
            Stoppate();
            riproduci.Play();
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
                
                timemanager.ContinueTime();
                riproduci.Play();
                //filtro.active = false;

            }
        }
        if (currentAbilityValue <= maxAbilityValue)
        {
            currentAbilityValue = currentAbilityValue + (Time.deltaTime * 0.25f);
        }
        abilityBar.SetValue(currentAbilityValue);

    }
    void Stoppate()
    {
        if (timemanager.TimeIsStopped)
        {
            UnityEngine.Debug.Log("go");
            timemanager.ContinueTime();
           // filtro.active = false;
        }
        else
        {
            if (currentAbilityValue > 0)
            {
                timemanager.StopTime();
               // filtro.active = true;

            }
        }

    }
}
