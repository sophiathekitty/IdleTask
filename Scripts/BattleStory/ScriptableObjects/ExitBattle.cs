using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Exit Battle", fileName = "Exit Battle")]
public class ExitBattle : StoryLine {
    public enum ExitReason { PlayerDead, EnemyDead, PlayerFlee }
    public ExitReason exitReason;

    public override bool CanDo
    {
        get
        {
            switch (exitReason)
            {
                case ExitReason.PlayerDead:
                    return player.health.RuntimeValue <= 0 && base.CanDo;
                case ExitReason.EnemyDead:
                    return enemy.health.RuntimeValue <= 0 && base.CanDo;
                case ExitReason.PlayerFlee:
                    return player.health.RuntimeValue < player.health.RuntimeValue * 0.1 && base.CanDo;
            }

            return base.CanDo;
        }
    }

    public override string MakeSentence()
    {
        isInBattle.RuntimeValue = false;
        return base.MakeSentence();
    }
}
