using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RaiseOnPlayerEnter : GameEventListener
{
    void OnCollisionEnter(Collision other)
    {
        print(other.gameObject.tag);
        if(other.gameObject.tag == "Player")
        {
            if(Event == null)
            {
                OnEventRaised();
            }
            else
            {
                Event.Raise();
            }
            
        }
    }
}
