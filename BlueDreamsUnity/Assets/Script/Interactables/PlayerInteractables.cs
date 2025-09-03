using UnityEngine;

public class PlayerInteractables : MonoBehaviour
{
    [SerializeField] private Camera myCam;
    private float rayDis = 3f;
    void Update()
    {
        CheckInteractables();
    }
    private void CheckInteractables()
    {
        RaycastHit hit;
        Vector3 rayOrigin = myCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.5f));

        if (Physics.Raycast(rayOrigin, myCam.transform.forward, out hit, rayDis))
        {
            Interactable interactable = hit.collider.GetComponent<Interactable>();
            if (interactable != null)
            {
                InteractionUIManager._instance.TriggerCursor(true);
                InteractionUIManager._instance.ShowInteractText(true);
                BasicInteraction(interactable);
            }
            else
            {
                InteractionUIManager._instance.ShowInteractText(false);
            }
        }
        else
        {
            InteractionUIManager._instance.ShowInteractText(false);
        }
    }
    private void BasicInteraction(Interactable interactable)
    {
        if(InputManager._instance.interactionPressed)Debug.Log("Nome do item: " + interactable.item.name);
    }
}
