using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeyScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;

    public GameObject timeManager;
    public int level;
    private bool entered=false;
    private bool countdown = false;
    private bool startTimer=false;
    public float timer = 60;

    public GameObject sugg;
    public GameObject aspetta;
    
    void Start()
    {
        sugg.active = false;
        aspetta.active = false;
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (GameStatus.GetCount() == true)
            {
                startTimer = true;
            }
        }
        else
        {
            if (GameStatus.GetCountUp() == true)
            {
                startTimer = true;
            }
        }
        
    }

    // Update is called once per frame
void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);

        if (startTimer == true)
        {
            timer -= Time.deltaTime;
            //dico che deve aspettare
        }

        if (timer < 0)
        {
            timer = 60;
            startTimer = false;
            countdown = false;
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                GameStatus.SetCount(countdown);
            }
            else
            {
                GameStatus.SetCountUp(countdown);
            }
           
        }

        if (entered)
        {
            if(startTimer == false)
            {
                sugg.active = true;
                aspetta.active = false;
            }
            else
            {
                sugg.active = false;
                aspetta.active = true;
            }

            if (startTimer == false && Input.GetKeyDown(KeyCode.I)) {


             countdown = true;
                if (SceneManager.GetActiveScene().buildIndex == 1)
                {
                    GameStatus.SetCount(countdown);
                }
                else
                {
                    GameStatus.SetCountUp(countdown);
                }


               

            timeManager.GetComponent<TimeSceneManager>().SceneChange(level);
        }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            entered = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == player.name)
        {
            entered = false;
            sugg.active = false;
            aspetta.active = false;
        }
    }
}
