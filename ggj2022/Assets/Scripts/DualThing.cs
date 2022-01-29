using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class DualThing : MonoBehaviour
{
    bool side;


    void Awake()
    {
        side = false;
        OnSideA();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SwapeSide()
    {
        side = !side;

        if(side)
        {
            OnSideB();
        }
        else
        {
            OnSideA();
        }
    }

    protected abstract void OnSideA();
    protected abstract void OnSideB();

}
