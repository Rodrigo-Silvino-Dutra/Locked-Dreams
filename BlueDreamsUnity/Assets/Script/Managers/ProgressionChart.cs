using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionChart : MonoBehaviour
{
    public static ProgressionChart _instance;
    public bool isInteracting = false;//Just alter in the OnInteract or in OnFocusExit of interactables that dont need to walk;
    void Start()
    {

    }
    void Awake()
    {
        if(_instance == null)_instance = this;
        DontDestroyOnLoad(_instance);
    }

}
