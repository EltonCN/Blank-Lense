using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class DualMaterial : DualThing
{
    [SerializeField] Material sideA;
    [SerializeField] Material sideB;

    new Renderer renderer;
 

    void getRenderer()
    {
        if(renderer == null)
        {
            renderer = GetComponent<Renderer>();
        }
    }

    
    protected override void OnSideA()
    {
        getRenderer();
        renderer.material = sideA;
    }

    protected override void OnSideB()
    {
        getRenderer();
        renderer.material = sideB;
    }

}
