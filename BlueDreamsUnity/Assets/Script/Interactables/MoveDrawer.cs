
















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
        
    }


}
