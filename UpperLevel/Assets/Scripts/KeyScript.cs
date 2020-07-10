using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;

    public GameObject timeManager;
    public int level;

    // Update is called once per frame
void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            Destroy(gameObject);

            Debug.Log("diomerda");
            timeManager.GetComponent<TimeSceneManager>().SceneChange(level);


        }
    }
}
