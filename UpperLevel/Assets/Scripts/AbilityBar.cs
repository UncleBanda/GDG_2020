using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityBar : MonoBehaviour
{
    public Slider slider;

    // Start is called before the first frame update
    public void SetValue(float value)
    {
        slider.value = value;
    }

    public void SetMaxValue(float value)
    {
        slider.maxValue = value;
    }

    //public void IsDead(float value)
    //{
    //  slider.value -= value;
    //}

}
