using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour, IInteractable
{
    [SerializeField] private string itemName;
    public void OnFocusEnter()
    {
    }

    public void OnFocusExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    public void OnInteract()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
        Debug.Log("Vc Pegou o item");
    }
}
