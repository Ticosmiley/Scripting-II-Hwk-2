using UnityEditor;
using UnityEngine;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

[CustomPropertyDrawer(typeof(Equipment))]
public class EquipmentDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        var indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        var nameRect = new Rect(position.x, position.y, position.width - 150, position.height);
        var slotRect = new Rect(position.x + position.width - 150, position.y, 50, position.height);
        var valueRect = new Rect(position.x + position.width - 100, position.y, 30, position.height);
        var rarityRect = new Rect(position.x + position.width - 70, position.y, 70, position.height);

        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("_name"), GUIContent.none);
        EditorGUI.PropertyField(slotRect, property.FindPropertyRelative("_slot"), GUIContent.none);
        EditorGUI.PropertyField(valueRect, property.FindPropertyRelative("_value"), GUIContent.none);
        EditorGUI.PropertyField(rarityRect, property.FindPropertyRelative("_rarity"), GUIContent.none);

        EditorGUI.indentLevel = indent;

        EditorGUI.EndProperty();
    }
}
