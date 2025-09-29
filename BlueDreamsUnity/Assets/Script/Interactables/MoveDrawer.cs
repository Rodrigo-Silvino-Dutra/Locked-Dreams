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
        //DEIXA QUETO POR ENQUANTO
        // if (isClosed)
        // {
        //     Vector3 target = new Vector3(openedPosition.position.x, transform.position.y, transform.position.z);
        //     transform.position = Vector3.MoveTowards(transform.position, target, 1);
        //     isClosed = false;
        // }
        // else
        // {
        //     Vector3 target = new Vector3(closedPosition.position.x, transform.position.y, transform.position.z);
        //     transform.position = Vector3.MoveTowards(transform.position, target, 1);
        //     isClosed = true;
        // }
    }
    //  IEnumerator OpenAndClose()
    // {
    //     while(transform.position != )
    //     {
            
    //     }
    //     yield return null; 
    // }

}
