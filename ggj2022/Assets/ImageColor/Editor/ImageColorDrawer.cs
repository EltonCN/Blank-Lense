using UnityEditor;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

[CustomPropertyDrawer(typeof(ImageColorBehaviour))]
public class ImageColorDrawer : PropertyDrawer
{
    public override float GetPropertyHeight (SerializedProperty property, GUIContent label)
    {
        int fieldCount = 1;
        return fieldCount * EditorGUIUtility.singleLineHeight;
    }

    public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
    {
        SerializedProperty colorProp = property.FindPropertyRelative("color");

        Rect singleFieldRect = new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight);
        EditorGUI.PropertyField(singleFieldRect, colorProp);
    }
}