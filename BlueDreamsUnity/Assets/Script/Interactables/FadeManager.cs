using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeManager : MonoBehaviour, IInteractable
{
    [SerializeField] public GameObject fade;
    public void OnFocusEnter()
    {
    }

    public void OnFocusExit()
    {
        
    }

    public void OnInteract()
    {
        fade.SetActive(true);
    }
}
