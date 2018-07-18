using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Battle Attack", fileName = "Battle Attack")]
public class BattleAttack : StoryLine {
    public Character attacker, defender;
    [Range(0f, 1f)]
    public float successRate;
    public float strengthDamage;
    public float willDamage;

    public float manaCost;

    public string hit;
    public string miss;

    public override bool CanDo
    {
        get
        {
            // uh... i guess make sure the attacker is alive....
            if (attacker.health.RuntimeValue <= 0 && defender.health.RuntimeValue <= 0)
                return false;

            if (manaCost > attacker.energy.RuntimeValue)
                return false;

            return base.CanDo;
        }
    }

    public override string MakeSentence()
    {
        string sent = base.MakeSentence();
        // roll dice to see if we hit
        if (Random.Range(0f, 1f) > attacker.perception.RuntimeValue * successRate)
        {
            // calculate damage
            float damage = 0f;
            float sd = attacker.strength.RuntimeValue * strengthDamage - defender.strength.RuntimeValue;
            float wd = attacker.will.RuntimeValue * willDamage - defender.will.RuntimeValue;
            if (sd > wd)
                damage = sd;
            else
                damage = wd;

            if (damage < 0)
                damage = 0f;

            defender.health.RuntimeValue -= damage;
            sent += " " + ApplyMadLib(hit);
            sent = sent.Replace("$damage",Mathf.Round(damage).ToString());
        }
        else
        {
            // build miss sentence
            sent += " " + ApplyMadLib(miss);
        }

        return sent;
    }

}
