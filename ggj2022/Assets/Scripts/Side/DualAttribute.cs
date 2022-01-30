using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AttributeBag))]
public class DualAttribute : DualThing
{
    [SerializeField] List<GameAttribute> sideA;
    [SerializeField] List<GameAttribute> sideB;

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

    void removeAllAttributes(List<GameAttribute> attributes)
    {
        foreach(GameAttribute a in attributes)
        {
            bag.RemoveAttribute(a);
        }
    }

    void addAllAttributes(List<GameAttribute> attributes)
    {
        foreach(GameAttribute a in attributes)
        {
            bag.AddAttribute(a);
        }
    }

}
