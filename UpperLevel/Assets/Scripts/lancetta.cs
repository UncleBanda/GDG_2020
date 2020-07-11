using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class lancetta : MonoBehaviour
{
    public Slider slider;
    public float value;
    public float speed = 30f;
    public float waitTime = 1.0f;
    public float currentTime = 0.0f;
    public float secondAngle = 0;
    bool isMoving = false;
    bool isEntered;

    void Start()
    {

        slider = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeSceneManager>().slider;


    }

    // Update is called once per frame
    void Update()
    {
        value = slider.value;

        if (Input.GetKeyDown(KeyCode.I) && isEntered)
        {
            if (isMoving == false)
            {

                isMoving = true;
            }
            else
            {
                float condition = (240 / 12) * (secondAngle / 30);
                Debug.Log(condition);
                if (slider.value <= (condition + 240 / 24) && slider.value >= (condition - 240 / 24))
                {
                    Debug.Log("you winner bibr");
                }
                isMoving = false;
            }
        }
        if (isMoving == true)
        {
            currentTime += Time.deltaTime;
            if (currentTime > waitTime)
            {
                secondAngle = secondAngle + 30;
                if (secondAngle == 360)
                {
                    secondAngle = 0;
                }
                currentTime = currentTime - waitTime;
            }
            transform.localRotation = Quaternion.Euler(0, 0, secondAngle);

        }
    }
    public void SetEntered(bool val)
    {
        isEntered = val;
    }
}