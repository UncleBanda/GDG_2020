using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeSceneManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider slider;
    public GameObject player;
    public GameObject respawner;
    public int level;
    public static int cont = 0;
    public Slider sliderBonus; //fool

    void Start()
    {
        slider.value = 0;
    

    }

    public void SceneChange(int level)
    {
        SceneManager.LoadScene(level);
    }

    // Update is called once per frame
    void Update()
    {
        slider.value += (Time.deltaTime);

        
        if (slider.value >= slider.maxValue)
        {
            SceneChange(level);
            cont=cont+2;
        }
        
        if(cont==2 && SceneManager.GetActiveScene().buildIndex == 0)
        {
            player.transform.position = new Vector3(-41.35f, 3.25f, 8.54f);
            //sliderBonus.value = 6;
        }
    }
}
