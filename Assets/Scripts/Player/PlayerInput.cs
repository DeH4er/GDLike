using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    InputActions inputActions;

    public InputAction Jump => inputActions.Player.Jump;
    public InputAction Pause => inputActions.Player.Pause;

    void Awake()
    {
        inputActions = new InputActions();
        inputActions.Player.Jump.Enable();
        inputActions.Player.Pause.Enable();
    }
}