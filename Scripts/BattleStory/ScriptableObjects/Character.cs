using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Characters/Character")]
public class Character : ScriptableObject
{
    public StringVariable full_name;        // ie: sophi of the pink stars
    public StringVariable short_name;       // ie: sophi
    public IntVariable level;               // the current level of the character... ratio of player/enemy 
    public AttributeVariable health;        // how much life they have
    public AttributeVariable energy;        // how much special they can use
    public AttributeVariable experience;    // for leveling up
    public FloatVariable strength;          // how much regular atk/def they have
    public FloatVariable will;              // how much special atk/def they have
    public FloatVariable stamina;           // how many action points they have
    public FloatVariable perception;        // their ability to find things and how likely they will land a hit/dodge in battle

}
