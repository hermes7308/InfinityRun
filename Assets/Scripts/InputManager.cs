using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public enum EType
    {
        InputSystem,
        Joystick
    }

    public Joystick joystick;
    public EType inputType;
    public Vector2 inputVec;

    void OnMove(InputValue inputValue)
    {
        if (inputType == EType.InputSystem)
        {
            inputVec = inputValue.Get<Vector2>();
        }
    }

    void Update()
    {
        if (inputType == EType.Joystick)
        {
            inputVec = joystick.Direction;
        }
    }
}
