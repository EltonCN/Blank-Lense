using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class DualThing : GameEventListener
{
    [SerializeField]SideState state;


    void Awake()
    {
        OnSwapeSide();

        Response.AddListener(this.OnSwapeSide);
    }


    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }


    public void OnSwapeSide()
    {
        if(state.actualSide == Side.SIDEA)
        {
            OnSideA();
        }
        else
        {
            OnSideB();
        }
    }

    protected abstract void OnSideA();
    protected abstract void OnSideB();

   
}
