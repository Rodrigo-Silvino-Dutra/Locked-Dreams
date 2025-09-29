using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCollect : MonoBehaviour, IInteractable
{ 
    public static int booksremaining = 12;
    public void OnFocusEnter()
    {
    }

    public void OnFocusExit()
    {
        
    }

    public void OnInteract()
    {
        booksremaining--;   
        Destroy(gameObject);
        Debug.Log("livros restantes:  " + booksremaining);
    }


}
