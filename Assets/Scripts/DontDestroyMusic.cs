using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class DontDestroyMusic : MonoBehaviour {

    private static DontDestroyMusic inst = null;
    private DontDestroyMusic()
    {
        
    }

    public static DontDestroyMusic instance
    {
        get {return inst;}       
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            inst = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
