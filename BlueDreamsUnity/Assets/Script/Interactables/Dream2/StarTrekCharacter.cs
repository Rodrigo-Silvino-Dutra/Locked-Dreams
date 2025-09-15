using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTrekCharacter : MonoBehaviour, IInteractable
{
    public string name;
    [SerializeField] private Transform holdingObject;
    public void OnFocusEnter()
    {

    }
    public void OnFocusExit()
    {

    }
    public void OnInteract()
    {
        if(!ProgressionChart._instance.isholdingStarTrekCharacter)
        {
            ProgressionChart._instance.isholdingStarTrekCharacter = true;
            gameObject.transform.position = holdingObject.position;
            gameObject.transform.SetParent(holdingObject, true);
        }
    }
}
