using UnityEngine;

public class MoveDrawer : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform openedPosition;
    private Transform closedPosition;
    private bool isClosed = true;
    void Awake()
    {
        closedPosition = gameObject.transform;
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
