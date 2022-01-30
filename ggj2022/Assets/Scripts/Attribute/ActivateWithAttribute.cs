using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AttributeBag))]
public class ActivateWithAttribute : MonoBehaviour
{
    [SerializeField] GameAttribute attribute;
    [SerializeField] List<MonoBehaviour> scripts;
    [SerializeField] List<GameObject> objects;

    AttributeBag bag;

    void Start()
    {
        bag = GetComponent<AttributeBag>();
    }

    void Update()
    {
        if(attribute == null)
        {
            return;
        }

        bool active = bag.HaveAttribute(attribute);


        foreach(GameObject obj in objects)
        {
            obj.SetActive(active);
        }
        foreach(MonoBehaviour script in scripts)
        {
            script.enabled = active;
        }
    }
}