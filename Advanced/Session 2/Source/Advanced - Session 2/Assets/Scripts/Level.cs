using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int xp;
    public int level
    {
        get { return xp / 250; }
    }
}
