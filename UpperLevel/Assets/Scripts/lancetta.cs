using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class lancetta : MonoBehaviour
{
    public Slider slider;
    public float value;
    public float speed = 30f;
    public float waitTime = 1.0f;
    public float currentTime = 0.0f;
    public float secondAngle = 0;
    public BigR bigRbool;
    bool isMoving = false;
    bool isEntered;
    public bool winningLancetta = false;
    public GameObject Rotellona;
    public GameObject Piattaforma;
    public Image fadeBlack;
    public GameObject FadeText;

    

    void Start()
    {
        UnityEngine.Debug.Log("" + slider.maxValue);
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
                float condition = (slider.maxValue / 12) * (secondAngle / 30);
               // Debug.Log(condition);
                if (slider.value <= (condition + slider.maxValue / 24) && slider.value >= (condition - slider.maxValue / 24))
                {
                    Debug.Log("you winner bibr");
                    winningLancetta = true;
                }
                /*else if (slider.value >= (condition + slider.maxValue / 24) && slider.value <= (condition - slider.maxValue / 24))
                {
                    winningLancetta = false;
                }*/
                
                isMoving = false;
            }
        }
        if((winningLancetta==true && bigRbool.winningBigR == true || GameStatus.GetPuzzle() )  && GameStatus.GetGem()==true)
        {
            Debug.Log("FINE DEMO, VITTORIA");
            /*Rotellona.GetComponent<Animator>().enabled=true;
            Piattaforma.GetComponent<Animator>().enabled = true;*/
           /* fadeBlack.GetComponent<Animator>().enabled = true;
            FadeText.gameObject.SetActive(true);*/
            GameStatus.SetPuzzle(true);
            Rotellona.GetComponent<Animator>().enabled = true;
            Piattaforma.GetComponent<Animator>().enabled = true;

        }
        if ((winningLancetta == true && bigRbool.winningBigR == true ) && GameStatus.GetGem() == false)
        {
            //ti manca la gemma
            GameStatus.SetPuzzle(true);
            Rotellona.GetComponent<Animator>().enabled = true;
            Piattaforma.GetComponent<Animator>().enabled = true;


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