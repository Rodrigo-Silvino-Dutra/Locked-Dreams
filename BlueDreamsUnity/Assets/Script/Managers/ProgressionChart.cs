using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionChart : MonoBehaviour
{
    public static ProgressionChart _instance;
    //DREAM 2
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
