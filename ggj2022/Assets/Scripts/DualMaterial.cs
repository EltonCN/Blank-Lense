using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualMaterial : DualThing
{
    [SerializeField] Material sideA;
    [SerializeField] Material sideB;

    Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame

    void OnValidate()
    {
        if(renderer == null)
        {
            renderer = GetComponent<Renderer>();
        }
        renderer.material = sideA;
    }

    
    protected override void OnSideA()
    {
        renderer.material = sideA;
    }

    protected override void OnSideB()
    {
        renderer.material = sideB;
    }

}
