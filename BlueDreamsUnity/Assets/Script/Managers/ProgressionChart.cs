using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionChart : MonoBehaviour
{
    public static ProgressionChart _instance;
    public bool isholdingStarTrekCharacter;
    public bool jupiterInPlace;
    void Start()
    {
        isholdingStarTrekCharacter = false;
        jupiterInPlace = false;
    }

    void start()
    {

    }

    void Awake()
    {
        if(_instance == null)_instance = this;
        DontDestroyOnLoad(_instance);
    }

}
