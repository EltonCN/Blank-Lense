using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialSide : MonoBehaviour
{
    [SerializeField] SideState state;
    [SerializeField] Side initialSide;

    void Start()
    {
        state.SetSide(initialSide);
        Destroy(this);
    }

    
}
