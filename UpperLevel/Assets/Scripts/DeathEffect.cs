using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DeathEffect : MonoBehaviour
{
    public ParticleSystem deathParticles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Die()
    {
       Instantiate(deathParticles, transform.position, deathParticles.transform.rotation);
       GetComponent<PlayerTimeManagement>().GemBonus(-1);      
    }
    
  
}
