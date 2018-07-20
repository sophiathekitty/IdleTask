using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Level Up")]
public class PlayerLevelUp : StoryLine {
    public override bool CanDo
    {
        get
        {
            if (player.experience.Percent >= 1f)
                return true;
            return false;
        }
    }
    public override string MakeSentence()
    {
        player.LevelUp();
        return base.MakeSentence();
    }
}
