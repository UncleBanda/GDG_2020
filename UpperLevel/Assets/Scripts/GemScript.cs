using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{

    public GameObject player;
    private MeshRenderer gem;
    public BonusAbility bonus;
    // Update is called once per frame

    private void Start()
    {
        gem = gameObject.GetComponent<MeshRenderer>();
    }
    void Update()
    {
        gem.transform.Rotate(0, 90 * Time.deltaTime, 0);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == player.name)
        {
            GameObject.Destroy(gameObject);
            bonus.GemBonus(3f);
        }
        
    }
}
