using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    static protected int phase = 0;
    static protected float maxAbility= 10f;
    [SerializeField] static protected Vector3 respawnUp ;
    [SerializeField] static protected Vector3 respawnDown ;
    static protected bool trovato = false;
    static protected bool countdown = false;
    static protected bool countdownup = false;
    static protected bool raccolta = false;
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


    public static void SetRespDown(Vector3 value)
    {
        respawnDown = value;
    }

    public static Vector3 GetRespDown()
    {
        return respawnDown;
    }


    public static void SetRespUp(Vector3 value)
    {
        respawnUp = value;
    }

    public static Vector3 GetRespUp()
    {
        return respawnUp;
    }


    public static void SetTrovato(bool value)
    {
        trovato = value;
        UnityEngine.Debug.Log("trovato=" + value);
    }

    public static bool GetTrovato()
    {
        return trovato;
    }

    public static void SetCount(bool value)
    {
        countdown = value;
        UnityEngine.Debug.Log("c=" + countdown);
    }

    public static bool GetCount()
    {
        return countdown;
    }

    public static void SetCountUp(bool value)
    {
        countdownup = value;
        
    }

    public static bool GetCountUp()
    {
        return countdownup;
    }

    public static void SetRaccolta(bool value)
    {
        raccolta = value;
        UnityEngine.Debug.Log("racc=" + raccolta);
    }

    public static bool GetRaccolta()
    {
        return raccolta;
    }
}
