using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AttributeBag : MonoBehaviour
{
    [SerializeField] List<GameAttribute> attributes;
    public UnityEvent OnAttributeChange;

    public void AddAttribute(GameAttribute attribute)
    {
        if(!attributes.Contains(attribute))
        {
            attributes.Add(attribute);

            OnAttributeChange.Invoke();
        }
    }

    public bool HaveAttribute(GameAttribute attribute)
    {
        return attributes.Contains(attribute);
    }

    public void RemoveAttribute(GameAttribute attribute)
    {
        if(attributes.Contains(attribute))
        {
            attributes.Remove(attribute);
            
            OnAttributeChange.Invoke();
        }
    }
}