using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleWithEvent : GameEventListener
{
    [SerializeField] List<GameObject> objects;

    // Start is called before the first frame update
    void Start()
    {
        Response.AddListener(this.OnEvent);
    }

    void OnEvent()
    {
        foreach(GameObject obj in objects)
        {
            obj.SetActive(!obj.activeInHierarchy);
        }
    }
}
