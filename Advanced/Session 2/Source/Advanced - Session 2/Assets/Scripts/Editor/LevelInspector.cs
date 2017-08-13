using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Level))]
public class LevelInspector : Editor
{
    private Level targetLevel;

    public void OnEnable()
    {
        targetLevel = (Level)target;
    }
    public override void OnInspectorGUI()
    {
        // base.OnInspectorGUI();
        DrawDefaultInspector();
        // targetLevel.xp = EditorGUILayout.IntField("XP: ", targetLevel.xp);
        EditorGUILayout.LabelField("Level: ", targetLevel.level.ToString());
        if (targetLevel.level > 10)
        {
            EditorGUILayout.LabelField("Message: ", "Baba damet garm");
        }
        else
        {
            EditorGUILayout.LabelField("Message: ", "hanooz jooje yi");
        }

        // //Update serialized object's representation.
        // serializedObject.Update();
        // //Apply property modifications.
        // serializedObject.ApplyModifiedProperties();

        // Implement any logic here!
        // compare fiels or properties, use for loop etc..
    }
}
