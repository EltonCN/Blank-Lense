using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonEvent : MonoBehaviour
{
    [SerializeField] GameEvent releaseEvent;

    public void OnButton(InputAction.CallbackContext context)
    {
        if(context.canceled)
        {
            releaseEvent.Raise();
        }
    }
}
