using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractionUIManager : MonoBehaviour//utilize o singleton desse script para criar variaveos de  controle, ou placar
{
    public static InteractionUIManager _instance;
    [SerializeField] private GameObject triggerReticlePointer;
    [SerializeField] private GameObject textOfInteraction;
    void Awake()
    {
        if(_instance == null)_instance = this;
        DontDestroyOnLoad(_instance);
    }
    public void TriggerCursor(bool state)
    {
        triggerReticlePointer.SetActive(state);
        textOfInteraction.SetActive(state);
    }
}
