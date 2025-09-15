using UnityEngine;

public class PlayerInteractables : MonoBehaviour
{
    [SerializeField] private Camera myCam;
    [SerializeField] private float rayDistance = 3f;

    private IInteractable currentInteractable;

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
                currentInteractable?.OnFocusExit();
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
        if (InputManager._instance.interactionPressed)
        {
            currentInteractable?.OnInteract();
        }
    }
}