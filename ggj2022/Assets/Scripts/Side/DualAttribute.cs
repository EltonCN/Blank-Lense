using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AttributeBag))]
public class DualAttribute : DualThing
{
    [SerializeField] List<Attribute> sideA;
    [SerializeField] List<Attribute> sideB;

    AttributeBag bag;
 

    void getBag()
    {
        if(bag == null)
        {
            bag = GetComponent<AttributeBag>();
        }
    }
    
    protected override void OnSideA()
    {
        getBag();

        removeAllAttributes(sideB);
        addAllAttributes(sideA);
    }

    protected override void OnSideB()
    {
        getBag();

        removeAllAttributes(sideA);
        addAllAttributes(sideB);
    }

    void removeAllAttributes(List<Attribute> attributes)
    {
        foreach(Attribute a in attributes)
        {
            bag.RemoveAttribute(a);
        }
    }

    void addAllAttributes(List<Attribute> attributes)
    {
        foreach(Attribute a in attributes)
        {
            bag.AddAttribute(a);
        }
    }

}
