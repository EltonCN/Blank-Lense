using UnityEngine;
using UnityEditor;
using System.IO;

[CreateAssetMenu(menuName ="Blank/Attribute")]
public class GameAttribute : ScriptableObject
{
    public GameAttribute inverse;

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
