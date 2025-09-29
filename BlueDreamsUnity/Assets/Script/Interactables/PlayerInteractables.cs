using UnityEngine;
using System;
using System.Collections.Generic;

public class PlayerInteractables : MonoBehaviour
{
    [SerializeField] private Camera myCam;
    [SerializeField] private float rayDistance = 3f;

    private IInteractable currentInteractable;
    Stack<IInteractable> PilhaInteragiveis = new Stack<IInteractable>();

    private void Update()
    {
        CheckInteractables();
    }

    private void CheckInteractables()
    {
        Ray ray = new(myCam.transform.position, myCam.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayDistance))//detecta se o raio bateu em algo
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();//pega o script do objeto observado

            if (interactable != currentInteractable)
            {
                InteractionUIManager._instance.TriggerCursor(true);
                currentInteractable = interactable;
                currentInteractable?.OnFocusEnter();
            }
        }
        else
        {
            currentInteractable?.OnFocusExit();
            currentInteractable = null;
        }
        if(currentInteractable == null)InteractionUIManager._instance.TriggerCursor(false);
    }

    public void InteractWithSubscribe() 
    {
        if(currentInteractable != null)Debug.Log("Existe");
        currentInteractable?.OnInteract();
        PilhaInteragiveis.Push(currentInteractable);
    }
    public void OutInteractWithSubscribe()
    {
        if(currentInteractable != null)Debug.Log("Existe e saindo da interacao");
        PilhaInteragiveis.Peek()?.OnFocusExit();
        PilhaInteragiveis.Pop();

    }
}