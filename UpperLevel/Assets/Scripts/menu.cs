using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime;
//using System.Runtime.Hosting;

public class menu : MonoBehaviour
{
    public GameObject cameraMenu;
    public GameObject menuCan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("CaveLevel", LoadSceneMode.Single);
        cameraMenu.SetActive(false);
        menuCan.SetActive(false);
    }
    public void QuitGame()
    {
        UnityEngine.Application.Quit();
    }
}
