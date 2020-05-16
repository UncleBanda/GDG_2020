using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 7;
    float distanceTravelled;
    float currentDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        if (Input.GetKey(KeyCode.D))
        {
            distanceTravelled += speed * Time.deltaTime;

            
        }
        if (Input.GetKey(KeyCode.A))
        {
            distanceTravelled -= speed * Time.deltaTime;


        }
    }
}
