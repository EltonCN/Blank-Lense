// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------
using System.Collections;

using UnityEngine;
using UnityEngine.Events;


public class GameEventListener : MonoBehaviour
{
    [Tooltip("Event to register with.")]
    public GameEvent Event;

    [Tooltip("Response to invoke when Event is raised.")]
    public UnityEvent Response;

    [SerializeField] float delay = 0;

    private void OnEnable()
    {
        if(Event != null)
        {
            Event.RegisterListener(this);
        }
    }

    private void OnDisable()
    {
        if(Event != null)
        {
            Event.UnregisterListener(this);
        }
    }

    public void OnEventRaised()
    {
        if(gameObject.activeInHierarchy)
        {
            StartCoroutine("RaiseResponse");
        }
        
    }

    IEnumerator RaiseResponse()
    {
        if(delay > 0)
        {
            yield return new WaitForSeconds(delay);
        }
        
        Response.Invoke();
    }
}
