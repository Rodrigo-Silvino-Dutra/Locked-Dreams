using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CodeManager : MonoBehaviour
{
    public TMP_InputField code;
    public string codeString = "teste";
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (code.text == codeString){
            Debug.Log("acertou");
        }
    }
}
