using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigR : MonoBehaviour
{
    public float speed = 30f;
    public float waitTime = 1.0f;
    public float currentTime = 0.0f;
    public float secondAngle = 0;
    public bool isMoving = false;
    public bool winningBigR = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
        else
        {
            if (this.transform.rotation.z == 0)
            {
                UnityEngine.Debug.Log("yay");
                winningBigR = true;
            }
        }

    }
}
