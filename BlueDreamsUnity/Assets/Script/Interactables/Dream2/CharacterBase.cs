using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform holdingObject;
    public void OnFocusEnter(){}
    public void OnFocusExit(){}
    public void OnInteract()
    {
        Transform starTrekDoll = holdingObject.GetChild(0);
        if(ProgressionChart._instance.isholdingStarTrekCharacter && starTrekDoll!=null)
        {
            ProgressionChart._instance.isholdingStarTrekCharacter = false;
            starTrekDoll.SetParent(holdingObject, false);
            starTrekDoll.position = gameObject.transform.position;
            starTrekDoll.SetParent(gameObject.transform, true);
        }
    }
}
