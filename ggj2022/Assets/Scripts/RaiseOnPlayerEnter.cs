using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RaiseOnPlayerEnter : MonoBehaviour
{
    [SerializeField] GameEvent gameEvent;
    void OnCollisionEnter(Collision other)
    {
        print(other.gameObject.tag);
        if(other.gameObject.tag == "Player")
        {
            gameEvent.Raise();
        }
    }
}
