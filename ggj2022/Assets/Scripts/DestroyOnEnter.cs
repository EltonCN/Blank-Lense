using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnEnter : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] GameEvent raiseOnDestroy;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.Equals(target))
        {
           Destroy(target);

           raiseOnDestroy.Raise();
        }
    }
}
