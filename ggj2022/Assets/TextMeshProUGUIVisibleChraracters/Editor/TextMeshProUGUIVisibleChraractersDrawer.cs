using UnityEditor;
using UnityEngine;
using UnityEngine.Playables;
using TMPro;

[CustomPropertyDrawer(typeof(TextMeshProUGUIVisibleChraractersBehaviour))]
public class TextMeshProUGUIVisibleChraractersDrawer : PropertyDrawer
{
    public override float GetPropertyHeight (SerializedProperty property, GUIContent label)
    {
        int fieldCount = 1;
        return fieldCount * EditorGUIUtility.singleLineHeight;
    }

    public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
    {
        SerializedProperty maxVisibleCharactersProp = property.FindPropertyRelative("maxVisibleCharacters");

        Rect singleFieldRect = new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight);
        EditorGUI.PropertyField(singleFieldRect, maxVisibleCharactersProp);
    }
}
