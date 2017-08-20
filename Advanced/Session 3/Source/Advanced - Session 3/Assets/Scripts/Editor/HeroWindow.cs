using UnityEditor;
using UnityEngine;

public class HeroWindow : EditorWindow
{
    [MenuItem("Window/Hero Window")]
    public static void ShowWindow()
    {
        var hwindow = EditorWindow.GetWindow(typeof(HeroWindow));
        hwindow.titleContent = new GUIContent("Institute Adv");
        hwindow.maxSize = new Vector2(400, 250);
        hwindow.minSize = new Vector2(300, 200);
    }

    GUIStyle headerStyle;
    private string heroName = "name...";
    private bool hasSword;
    private float swordDmg;
    private string heroDesc = "Description...";
    void OnEnable()
    {
        headerStyle = new GUIStyle();
        headerStyle.fontSize = 20;
        headerStyle.fontStyle = FontStyle.Bold;
        headerStyle.alignment = TextAnchor.UpperCenter;
    }

    void OnGUI()
    {
        EditorGUILayout.LabelField("Hero Generator", headerStyle);
        EditorGUILayout.Space();

        heroName = EditorGUILayout.TextField("Name:", heroName);

        EditorGUILayout.BeginHorizontal();
        heroDesc = EditorGUILayout.TextField("Desc:", heroDesc);

        EditorGUILayout.EndHorizontal();

        hasSword = EditorGUILayout.BeginToggleGroup("Has Sword:", hasSword);
        // hasSword = EditorGUILayout.Toggle("Has Sword:", hasSword);
        swordDmg = EditorGUILayout.Slider("Sword Dammage", swordDmg, 0, 10);
        EditorGUILayout.EndToggleGroup();

        if (GUILayout.Button("Generate hero"))
        {
            Debug.Log("hero was generated!");
        }
    }
}
