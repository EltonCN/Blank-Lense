using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class Player3DMoviment : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(InputAction.CallbackContext context)
    {
        Vector2 playerInput = context.ReadValue<Vector2>();

        Vector3 playerInput3D = new Vector3(playerInput.x, 0.0f, playerInput.y);

        Vector3 step = 100f * playerInput3D * Time.deltaTime;

        Vector3 finalPosition = step + this.transform.position;

        rb.MovePosition(finalPosition);
    }
}
