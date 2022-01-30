using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // #pragma warning disable 649

    [SerializeField] float sensitivityX = 8f;
    [SerializeField] float sensitivityY = 0.5f;
    float mouseX, mouseY;

    //[SerializeField] List<Transform> cameras;
    [SerializeField] GameObject cameraHolder;
    [SerializeField] float xClamp = 85f;
    float xRotation = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, mouseX * Time.deltaTime);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -xClamp, +xClamp);
        Vector3 targetRotation = transform.eulerAngles;
        targetRotation.x = xRotation;

        foreach(Transform transform in cameraHolder.GetComponentInChildren<Transform>())
        {
            transform.eulerAngles = targetRotation;
        }
        //foreach(Transform transform in cameras)
        //{
        //    transform.eulerAngles = targetRotation;
        //}
    }
    
    public void ReceiveInput(Vector2 mouseInput)
    {
        mouseX = mouseInput.x * sensitivityX;
        mouseY = mouseInput.y * sensitivityY;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
