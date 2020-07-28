using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeSceneManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider slider;
    public int level;
    public static int cont = 0;
    private TimeManager timemanager;

    void Start()
    {
        slider.value = 0;
        timemanager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();

    }

    public void SceneChange(int level)
    {
        SceneManager.LoadScene(level);
    }

    // Update is called once per frame
    void Update()
    {
        if (timemanager.TimeIsStopped == false)
        {
            slider.value += (Time.deltaTime);
        }
        
        if (slider.value >= slider.maxValue)
        {
            SceneChange(level);
        }

    }
}
