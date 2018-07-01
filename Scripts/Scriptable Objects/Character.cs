using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Characters/Character")]
public class Character : ScriptableObject
{
    public string full_name;
    public string short_name;
    public IntVariable level;
    public AttributeVariable health;
    public AttributeVariable energy;
    public AttributeVariable experience;
    public FloatVariable strength;
    public FloatVariable will;
    public FloatVariable stamina;
    public FloatVariable perception;
    public FloatVariable speed;
}
