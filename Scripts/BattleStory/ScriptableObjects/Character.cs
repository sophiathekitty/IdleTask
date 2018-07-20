using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Characters/Character")]
public class Character : ScriptableObject
{
    public StringVariable full_name;        // ie: sophi of the pink stars
    public StringVariable short_name;       // ie: sophi

    public StringVariable they;             // they/she/he
    public StringVariable their;            // thier/her/his
    public StringVariable theirs;           // theirs/hers/his
    public StringVariable them;             // them/her/him
    public StringVariable themself;        // them/her/him

    public Color color;                     // color for their name to show up in

    public IntVariable level;               // the current level of the character... ratio of player/enemy 
    public AttributeVariable health;        // how much life they have
    public AttributeVariable energy;        // how much special they can use
    public AttributeVariable experience;    // for leveling up
    public FloatVariable strength;          // how much regular atk/def they have
    public FloatVariable will;              // how much special atk/def they have
    public FloatVariable stamina;           // how many action points they have
    public FloatVariable perception;        // their ability to find things and how likely they will land a hit/dodge in battle

    public void Respawn()
    {
        health.RuntimeValue = health.RuntimeMax;
        energy.RuntimeValue = energy.RuntimeMax;
        stamina.RuntimeValue = 0;
    }

    public bool IsDead
    {
        get
        {
            return health.RuntimeValue <= 0;
        }
    }

    public void ApplyPreset(EnemyDefinition enemy)
    {
        full_name.RuntimeValue = enemy.full_name;
        short_name.RuntimeValue = enemy.short_name;

        color = enemy.color;

        level.RuntimeValue = enemy.level;
        health.RuntimeValue = health.RuntimeMax = enemy.health;
        energy.RuntimeValue = energy.RuntimeMax = enemy.energy;
        experience.RuntimeValue = experience.RuntimeMax = enemy.experience;

        strength.RuntimeValue = enemy.strength;
        will.RuntimeValue = enemy.will;
        //stamina.RuntimeValue += enemy.stamina;
        perception.RuntimeValue = enemy.perception;
    }
}
