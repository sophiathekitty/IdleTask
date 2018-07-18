using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Enter Battle", fileName = "Enter Battle")]
public class EnterBattle : StoryLine {

    public override bool CanDo
    {
        get
        {
            if (enemy.health.RuntimeValue <= 0 || player.health.RuntimeValue <= 0)
                return false;
            return base.CanDo;
        }
    }

    public override string MakeSentence()
    {
        isInBattle.RuntimeValue = true;
        return base.MakeSentence();
    }
}
