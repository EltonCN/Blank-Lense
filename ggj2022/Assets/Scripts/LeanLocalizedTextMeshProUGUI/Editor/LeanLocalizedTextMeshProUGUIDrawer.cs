using UnityEditor;
using UnityEngine;
using UnityEngine.Playables;
using Lean.Localization;

[CustomPropertyDrawer(typeof(LeanLocalizedTextMeshProUGUIBehaviour))]
public class LeanLocalizedTextMeshProUGUIDrawer : PropertyDrawer
{
    public override float GetPropertyHeight (SerializedProperty property, GUIContent label)
    {
        int fieldCount = 1;
        return fieldCount * EditorGUIUtility.singleLineHeight;
    }

    public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
    {
        SerializedProperty TranslationNameProp = property.FindPropertyRelative("TranslationName");

        Rect singleFieldRect = new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight);
        EditorGUI.PropertyField(singleFieldRect, TranslationNameProp);
    }
}
