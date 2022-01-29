using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureObject : MonoBehaviour
{
    Transform originalParent;
    int originalLayer;
    bool captured = false;
    GameObject obj;
    Rigidbody rb;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Capture()
    {
        if(captured)
        {
            obj.transform.parent = originalParent;
            obj.layer = originalLayer;

            captured = !captured;

            if(rb != null)
            {
                rb.isKinematic = false;
            }
            rb = null;
            obj = null;
        }
        else
        {
            RaycastHit hitInfo;
            bool hit = Physics.Raycast(this.transform.position, this.transform.forward, out hitInfo, Mathf.Infinity);

            if(hit)
            {
                obj = hitInfo.transform.gameObject;

                originalParent = obj.transform.parent;
                originalLayer = obj.layer;

                obj.layer = 6;
                obj.transform.parent = this.transform;
                
                rb = obj.GetComponent<Rigidbody>();
                if(rb != null)
                {
                    rb.isKinematic = true;
                }

                captured = !captured;
            }
        }

        
    }
}
