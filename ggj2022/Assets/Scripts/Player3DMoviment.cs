using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class Player3DMoviment : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] Camera camera;
    Rigidbody rb;

    bool moving = false;
    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(moving)
        {
            Vector3 playerInput3D = new Vector3(direction.x, 0.0f, direction.y);
            //camera.transform.rotation

            
            
            Vector3 step = speed * playerInput3D * Time.deltaTime;
            Vector3 finalPosition = step + this.transform.position;
            rb.MovePosition(finalPosition);
        }
        
    }

    public void Move(InputAction.CallbackContext context)
    {
        if(context.started || context.performed)
        {
            moving = true;
            direction = context.ReadValue<Vector2>();
        }
        else
        {
            moving = false;
        }

        
    }
}
