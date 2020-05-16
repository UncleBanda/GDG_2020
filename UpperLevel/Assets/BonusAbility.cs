using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusAbility : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public static float bonus = 9f;

    // Start is called before the first frame update
    public void SetValue(float value)
    {
        slider.value = value;
    }
    public void GemBonus(float num)
    {
        bonus = bonus +3f;
        slider.value = bonus;

    }

    public void SetMaxValue(float value)
    {
        slider.maxValue = value;
        slider.value = value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
