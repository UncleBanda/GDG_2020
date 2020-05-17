using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTimeManagement : MonoBehaviour
{
    // Start is called before the first frame update
    private TimeManager timemanager;
    public AbilityBar abilityBar;
    public BonusAbility bonusBar;
    static public float maxAbilityValue = 10f; //static perchè cosi viene salvato di scena in scen e non si resetta
    static public float currentAbilityValue;
    static public float currentBonusValue=0;
    private bool bonusAtt = false;





    // Start is called before the first frame update
    void Start()
    {
        timemanager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
        currentAbilityValue = maxAbilityValue;
        abilityBar.SetMaxValue(maxAbilityValue);
    }
      public void GemBonus()
    {
        currentBonusValue = currentBonusValue + 3;
        bonusBar.SetValue(currentBonusValue);
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
                if (currentBonusValue > 0)
                {
                    currentBonusValue -= Time.deltaTime;
                    bonusBar.SetValue(currentBonusValue);
                    bonusAtt = true;
                }
                else
                {
                    bonusAtt = false;
                    currentAbilityValue -= Time.deltaTime;
                    abilityBar.SetValue(currentAbilityValue);
                }
            }
            else
            {
                
                timemanager.ContinueTime();

            }
        }
        if ((timemanager.TimeIsStopped==false&&currentAbilityValue<10)||(bonusAtt==true && currentAbilityValue < 10))
        {

            currentAbilityValue = currentAbilityValue+ (Time.deltaTime*0.25f);
            abilityBar.SetValue(currentAbilityValue);
        }
    }
}
