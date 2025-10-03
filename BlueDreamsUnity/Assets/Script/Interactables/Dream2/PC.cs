using UnityEngine;

public class PC : MonoBehaviour, IInteractable
{
    [SerializeField] private Transform holdingObject;
    [SerializeField] private GameObject screen;
    private string pc = "Linux";

    public void OnFocusEnter()
    {
    }
    public void OnFocusExit()
    {
    }
    public void OnInteract()
    {
        Transform cd = holdingObject.GetChild(0);
        if (ProgressionDream2._instance.isHoldingCD && cd != null)
        {
            Debug.Log("PEGOU O CD E ESTA TENTANDO INTERAGIR");
            if (cd.CompareTag(pc))
            {
                Destroy(cd.gameObject);
                screen.SetActive(true);

            }
        }
    }
}
