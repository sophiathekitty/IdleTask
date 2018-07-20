using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Enemy Preset")]
public class EnemyDefinition : ScriptableObject {
    public string full_name;        // ie: sophi of the pink stars
    public string short_name;       // ie: sophi

    public Sprite sprite;           // what they looks like in battles

    public Color color;             // color for their name to show up in

    public int level;               // the current level of the character... ratio of player/enemy 
    public float health;            // how much life they have
    public float energy;            // how much special they can use
    public float experience;        // for leveling up
    public float strength;          // how much regular atk/def they have
    public float will;              // how much special atk/def they have
    public float stamina;           // how many action points they have
    public float perception;        // their ability to find things and how likely they will land a hit/dodge in battle
}
