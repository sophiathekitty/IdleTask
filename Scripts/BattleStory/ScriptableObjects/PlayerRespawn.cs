using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Player Respawn")]
public class PlayerRespawn : StoryLine {
    public override bool CanDo
    {
        get
        {
            if(player.IsDead && !isInBattle.RuntimeValue)
                return true;

            return base.CanDo;
        }
    }
    public override string MakeSentence()
    {
        player.Respawn();
        return base.MakeSentence();
    }
}
