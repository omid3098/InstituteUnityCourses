using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Level))]
public class LevelInspector : Editor
{
    public override void OnInspectorGUI()
    {
        Level targetLevel = (Level)target;

        targetLevel.xp = EditorGUILayout.IntField("XP: ", targetLevel.xp);
        EditorGUILayout.LabelField("Level: ", targetLevel.level.ToString());

		// //Update serialized object's representation.
        // serializedObject.Update();
		// //Apply property modifications.
		// serializedObject.ApplyModifiedProperties();

		// Implement any logic here!
		// compare fiels or properties, use for loop etc..
    }
}
