using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class OrologioSlider : MonoBehaviour
{

    public Slider slider;
    public Transform LoadingBar;
    // Start is called before the first frame update
    void Start()
    {
        LoadingBar.GetComponent<Image>().fillAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        LoadingBar.GetComponent<Image>().fillAmount = slider.value/slider.maxValue;
    }
}
