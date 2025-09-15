using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Padlock : MonoBehaviour, IInteractable
{
    Vector3 originPosition;
    public Transform objectViwer;
    private int[] result, correctCombination;
    private bool isOpened;
    private void Start()
    {
        originPosition = transform.position;
        result = new int[]{0,0,0,0};
        correctCombination = new int[] {6,7,8,4};
        isOpened = false;
        Rotate.Rotated += CheckResults;
    }

    private void CheckResults(string wheelName, int number)
    {
        switch (wheelName)
        {
            case "WheelOne":
                result[0] = number;
                break;

            case "WheelTwo":
                result[1] = number;
                break;

            case "WheelThree":
                result[2] = number;
                break;

            case "WheelFour":
                result[3] = number;
                break;
        }

        if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2] && result[3] == correctCombination[3] && !isOpened)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
            isOpened = true;
        }
    }

    private void OnDestroy()
    {
        Rotate.Rotated -= CheckResults;
    }

    public void OnFocusEnter(){
transform.LookAt(objectViwer);
    }
    public void OnInteract()
    {
        transform.position = objectViwer.transform.position;
        
    }
    
    public void OnFocusExit(){

    }
}
