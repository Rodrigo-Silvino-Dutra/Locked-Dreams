using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionDream2 : MonoBehaviour
{
    public static ProgressionDream2 _instance;
    public bool isholdingStarTrekCharacter;
    public bool jupiterInPlace;

    void Start()
    {
        isholdingStarTrekCharacter = false;
        jupiterInPlace = false;
    }
    void Awake()
    {
        if(_instance == null)_instance = this;
        DontDestroyOnLoad(_instance);
    }
}

