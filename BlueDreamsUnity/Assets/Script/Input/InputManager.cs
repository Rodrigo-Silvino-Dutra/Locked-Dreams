using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;


public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private InputAction moveAction;
    private InputAction moveCamAction;
    private InputAction interaction;

    public Vector2 xzPlayer, xyCam;
    public bool interactionPressed;

    public static InputManager _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(_instance);
        }

        playerInput = GetComponent<PlayerInput>();

        moveAction = playerInput.actions["Move"];
        moveCamAction = playerInput.actions["Look"];
        interaction = playerInput.actions["Interact"];
    }
    private void OnEnable()
    {
        moveAction.Enable();
        moveCamAction.Enable();
        interaction.Enable();

        moveAction.performed += OnMoveEvent;
        moveAction.canceled += OnMoveEvent;

        moveCamAction.performed += OnMoveCameraEvent;
        moveCamAction.canceled += OnMoveCameraEvent;

        interaction.started += OnInteract;
        interaction.canceled += OnInteract;

    }
    private void OnDisable()
    {
        moveAction.performed -= OnMoveEvent;
        moveAction.canceled -= OnMoveEvent;

        moveCamAction.performed -= OnMoveCameraEvent;
        moveCamAction.canceled -= OnMoveCameraEvent;

        interaction.started -= OnInteract;
        interaction.canceled -= OnInteract;
    }
    public void OnMoveEvent(InputAction.CallbackContext valueMove)
    {
        xzPlayer.x = valueMove.ReadValue<Vector2>().x;
        xzPlayer.y = valueMove.ReadValue<Vector2>().y;
    }
    public void OnMoveCameraEvent(InputAction.CallbackContext valueCamMove)
    {
        xyCam.x = valueCamMove.ReadValue<Vector2>().x;
        xyCam.y = valueCamMove.ReadValue<Vector2>().y;
    }
    public void OnInteract(InputAction.CallbackContext valueInteract)
    {
        if (valueInteract.started)interactionPressed = true;
        else if (valueInteract.canceled)interactionPressed = false;
    }    
}