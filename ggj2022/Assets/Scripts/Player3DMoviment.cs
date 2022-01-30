using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player3DMoviment : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpSpeed = 5f;
    [SerializeField] new Camera camera;
    [SerializeField] Rigidbody player;

    bool moving = false;
    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
    }

    void FixedUpdate()
    {
        if(moving)
        {
            Vector3 playerInput3D = new Vector3(direction.x, 0.0f, direction.y);

            Quaternion rotation = camera.transform.rotation;
            Vector3 angles = rotation.eulerAngles;
            angles.x = 0;
            angles.z = 0;
            rotation = Quaternion.Euler(angles);

            playerInput3D = camera.transform.rotation * playerInput3D;
            playerInput3D.y = 0;

            Vector3 step = speed * playerInput3D * Time.deltaTime;
            Vector3 finalPosition = step + this.transform.position;
            player.MovePosition(finalPosition);
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

    public void Jump(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            Vector3 velocity = player.velocity;
            velocity.y = jumpSpeed;

            player.velocity = velocity;
        }
    }
}
