using UnityEngine;
using UnityEditor;
using System.IO;

[CreateAssetMenu(menuName ="Blank/Attribute")]
public class Attribute : ScriptableObject
{
    public Attribute inverse;

    void Awake()
    {
        OnValidate();
    }

    void OnValidate()
    {
        if(inverse != null)
        {
            inverse.inverse = this;
        }
    }
}
