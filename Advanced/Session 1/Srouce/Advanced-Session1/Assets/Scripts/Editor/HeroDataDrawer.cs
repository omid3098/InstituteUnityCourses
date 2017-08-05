using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(HeroData))]
public class HeroDataDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // Begin property so store changes.
        label = EditorGUI.BeginProperty(position, label, property);
        // draw property label
        Rect labelRect = EditorGUI.PrefixLabel(position, label);
        // set rect height to 16 because we have 2 line and total height will be 34 (16 + 16 +2 margin)
        labelRect.height = 16;
        // draw name property in the first line.
        EditorGUI.PropertyField(labelRect, property.FindPropertyRelative("name"), GUIContent.none);
        // add 16 + 2 margin to draw the rest at the second line
        labelRect.y += 18;
        // we first draw vector3 at 75% of the space and then draw the color at the remaining 25% 
        labelRect.width *= 0.75f;
        // drawing position vector
        EditorGUI.PropertyField(labelRect, property.FindPropertyRelative("position"), GUIContent.none);
        // put rect x at the begining of the 75% to draw the rest 25%
        labelRect.x += labelRect.width;
        // calculate to have 25% of the total width
        labelRect.width /= 3f;
        // label defaulr width usually is bigger that what we expect. set it to our desire width "C" 
        EditorGUIUtility.labelWidth = 14f;
        // Draw color field at the calculated position.
        EditorGUI.PropertyField(labelRect, property.FindPropertyRelative("color"), new GUIContent("C"));
        // Property ends here
        EditorGUI.EndProperty();
    }
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        // 16 FirstLine + 16 SecondLine + 2 Margin
        return 34f;
    }
}