using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHide : MonoBehaviour
{
    public void Hide()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Show()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
