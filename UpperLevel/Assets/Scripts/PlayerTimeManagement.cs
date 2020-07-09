using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTimeManagement : MonoBehaviour
{
    // Start is called before the first frame update
    private TimeManager timemanager;
    public AbilityBar abilityBar;
    public float maxAbilityValue = 10f; //static perchè cosi viene salvato di scena in scen e non si resetta
    public float currentAbilityValue;

    // Start is called before the first frame update
    void Start()
    {
        timemanager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
        currentAbilityValue = maxAbilityValue;
        abilityBar.SetMaxValue(maxAbilityValue);
        abilityBar.SetValue(currentAbilityValue);
    }
      public void GemBonus(int value)
    {
        maxAbilityValue = maxAbilityValue + (3)*value;
        abilityBar.SetMaxValue(maxAbilityValue);
        currentAbilityValue = maxAbilityValue;
    }

   
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.O)) //Stop Time when Q is pressed
        {
            Stoppate();

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
        }
        else
        {
            if (currentAbilityValue > 0)
            {
                timemanager.StopTime();

            }
        }

    }
}
