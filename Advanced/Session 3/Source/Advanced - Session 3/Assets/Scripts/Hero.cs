using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class Hero : ScriptableObject
{
    public string heroName;
    public string heroDesc;
    public bool hasSword;
    public float swordDammage;
}
