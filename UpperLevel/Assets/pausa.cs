using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausa : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject options;
    public GameObject menuIniziale;
    public GameObject player;
    public Animator animatorPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (menuIniziale.activeSelf == false)
            {
                if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }

        if (player == null)
        {
            player = GameObject.Find("principessinarig1");
            if (player != null)
            {
                animatorPlayer = player.transform.GetComponent<Animator>();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        animatorPlayer.enabled = true;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        animatorPlayer.enabled = false;
        options.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Opzioni()
    {
        options.SetActive(true);
        pauseMenuUI.SetActive(false);
    }
}