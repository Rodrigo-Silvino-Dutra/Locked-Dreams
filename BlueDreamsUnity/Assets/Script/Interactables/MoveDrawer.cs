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
            transform.position = Vector3.MoveTowards(transform.position, openedPosition.position, 1);
            isClosed = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, closedPosition.position, 1);
            isClosed = true;
        }
    }
    //  IEnumerator OpenAndClose()
    // {
    //     while(transform.position != )
    //     {
            
    //     }
    //     yield return null; 
    // }

}
