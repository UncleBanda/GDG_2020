using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    static protected int phase = 0;
    static protected float maxAbility= 10f;
    [SerializeField] static protected Transform respawnUp = null;
    [SerializeField] static protected Transform respawnDown = null;
    // Start is called before the first frame update    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static void SetPhase(int value)
    {
        phase = value;
    }

    public static int GetPhase()
    {
        return phase;
    }

    public static void SetMaxAbility(float value)
    {
        maxAbility = value;
    }

    public static float GetMaxAbility()
    {
        return maxAbility;
    }

    public static void SetRespDown(Transform value)
    {
        respawnDown = value;
    }

    public static Transform GetRespDown()
    {
        return respawnDown;
    }
}
