using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(AttributeBag))]
[RequireComponent(typeof(Rigidbody))]
public class FloatWithFire : MonoBehaviour
{
    AttributeBag bag;
    Rigidbody rb;

    [SerializeField] GameAttribute fireAttribute;

    void Start()
    {
        bag = GetComponent<AttributeBag>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(bag.HaveAttribute(fireAttribute))
        {
            rb.AddForce(new Vector3(0,1,0));
        }
    }
}
