using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Level")]
public class ActionLevel : ScriptableObject {
    public Color background;
    public Color text;
    public Color count;
    public Color cooldown;
    public float cooldownTime;
    public AudioClip sound;
    public FloatVariable actionPoints;

    public void GrantActionPoints(int streak)
    {
        if (actionPoints != null)
            actionPoints.RuntimeValue += cooldownTime * streak;
    }
}
