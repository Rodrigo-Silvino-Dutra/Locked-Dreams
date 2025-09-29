using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionDream2 : MonoBehaviour
{
    public static ProgressionDream2 _instance;
    public bool isholdingStarTrekCharacter;
    public GameObject galileoPuzzle;
    public bool[] dollsPlaced = new bool[3];//data = 0; picard = 1; worf = 2;
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
    public void ActiveGalileoPuzzle(bool valueOfDollPlaced, int index)
    {
        if(valueOfDollPlaced && index == 1)galileoPuzzle.SetActive(true);
    }
}

