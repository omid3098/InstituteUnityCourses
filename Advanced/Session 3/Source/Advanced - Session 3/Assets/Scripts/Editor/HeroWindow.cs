using UnityEditor;
using UnityEngine;
using System.IO;
public class HeroWindow : EditorWindow
{
    [MenuItem("Window/Hero Generator")]
    public static void ShowWindow()
    {
        var hwindow = EditorWindow.GetWindow(typeof(HeroWindow));
        hwindow.titleContent = new GUIContent("Institute Adv");
        hwindow.maxSize = new Vector2(400, 250);
        hwindow.minSize = new Vector2(300, 200);
    }

    GUIStyle headerStyle;
    // private string heroName = "name...";
    // private bool hasSword;
    // private float swordDmg;
    // private string heroDesc = "Description...";
    private Hero hero;
    void OnEnable()
    {
        hero = ScriptableObject.CreateInstance<Hero>();
        headerStyle = new GUIStyle();
        headerStyle.fontSize = 20;
        headerStyle.fontStyle = FontStyle.Bold;
        headerStyle.alignment = TextAnchor.UpperCenter;
    }

    void OnGUI()
    {
        EditorGUILayout.LabelField("Hero Generator", headerStyle);
        EditorGUILayout.Space();

        hero.heroName = EditorGUILayout.TextField("Name:", hero.heroName);

        EditorGUILayout.BeginHorizontal();
        hero.heroDesc = EditorGUILayout.TextField("Desc:", hero.heroDesc);
        EditorGUILayout.EndHorizontal();

        hero.hasSword = EditorGUILayout.BeginToggleGroup("Has Sword:", hero.hasSword);
        hero.swordDammage = EditorGUILayout.Slider("Sword Dammage", hero.swordDammage, 0, 10);
        EditorGUILayout.EndToggleGroup();

        if (GUILayout.Button("Generate hero"))
        {
            Debug.Log("hero was generated!");
            string _directory = "Assets/" + "heroes/";
            string _fileName = hero.heroName + ".asset";
            if (!Directory.Exists(_directory))
            {
                Directory.CreateDirectory(_directory);
            }
            if (File.Exists(_directory + _fileName))
            {
                File.Delete(_directory + _fileName);
            }
            AssetDatabase.CreateAsset(hero, _directory + _fileName);
        }
    }
}
