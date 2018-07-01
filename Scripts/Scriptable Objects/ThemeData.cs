using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Fidget/Theme/New")]
public class ThemeData : ScriptableObject {
    [Header("Color Pallet")]
    public Color header;
    public Color background;
    public Color button;
    public Color text;
}
