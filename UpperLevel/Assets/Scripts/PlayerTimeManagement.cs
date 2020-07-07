using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTimeManagement : MonoBehaviour
{
    // Start is called before the first frame update
    private TimeManager timemanager;
    public AbilityBar abilityBar;
    static public float maxAbilityValue = 10f; //static perchè cosi viene salvato di scena in scen e non si resetta
    static public float currentAbilityValue;
    static public float currentBonusValue=0f;
    private bool bonusAtt = false;





    // Start is called before the first frame update
    void Start()
    {
        timemanager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
        currentAbilityValue = maxAbilityValue;
        abilityBar.SetMaxValue(maxAbilityValue);
    }
      public void GemBonus(int value)
    {
        currentBonusValue = currentAbilityValue + (3.33f)*value;
        abilityBar.SetMaxValue(currentBonusValue);
        UnityEngine.Debug.Log("" + currentBonusValue);
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
                
                timemanager.ContinueTime();

            }
        }
        if ((timemanager.TimeIsStopped==false&&currentAbilityValue<currentBonusValue)||(bonusAtt==true && currentAbilityValue < currentBonusValue))
        {

            currentAbilityValue = currentAbilityValue+ (Time.deltaTime*0.25f);
            abilityBar.SetValue(currentAbilityValue);
        }
    }
}
