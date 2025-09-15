using UnityEngine;

public class MoveDrawer : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform openedPosition;
    [SerializeField] private Transform closedPosition;
    private bool isClosed;
    void Awake()
    {
        isClosed = true;
    }
    public void OnFocusEnter()
    {
    }
    public void OnFocusExit()
    {
    }
    public void OnInteract()
    {
        if (isClosed)
        {
            transform.position = Vector3.MoveTowards(closedPosition.position, openedPosition.position, Time.fixedDeltaTime);
            isClosed = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(openedPosition.position, closedPosition.position, Time.fixedDeltaTime);
            isClosed = true;
        }
    }
}
