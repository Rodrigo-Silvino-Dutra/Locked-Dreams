using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Codemanager : MonoBehaviour
{
    public TMP_InputField code;
    public string codetext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(code.text == codetext)
        {
            Debug.Log("Correct Code");
        }
    }
}
