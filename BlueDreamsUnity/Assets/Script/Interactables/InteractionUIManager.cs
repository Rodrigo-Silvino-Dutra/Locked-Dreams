using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionUIManager : MonoBehaviour
{
    public static InteractionUIManager _instance;
    [SerializeField] private GameObject triggerReticlePointer;
    void Awake()
    {
        if(_instance == null)_instance = this;
        DontDestroyOnLoad(_instance);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TriggerCursor(bool state)
    {
        triggerReticlePointer.SetActive(state);
    }
}
