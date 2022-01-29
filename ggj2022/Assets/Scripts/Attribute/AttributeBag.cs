using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AttributeBag : MonoBehaviour
{
    [SerializeField] List<Attribute> attributes;
    public UnityEvent OnAttributeChange;

    public void AddAttribute(Attribute attribute)
    {
        if(!attributes.Contains(attribute))
        {
            attributes.Add(attribute);

            OnAttributeChange.Invoke();
        }
    }

    public bool HaveAttribute(Attribute attribute)
    {
        return attributes.Contains(attribute);
    }

    public void RemoveAttribute(Attribute attribute)
    {
        if(attributes.Contains(attribute))
        {
            attributes.Remove(attribute);
            
            OnAttributeChange.Invoke();
        }
    }
}