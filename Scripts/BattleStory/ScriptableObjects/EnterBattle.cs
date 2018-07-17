using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Enter Battle", fileName = "Enter Battle")]
public class EnterBattle : StoryLine {
    public override string MakeSentence()
    {
        isInBattle.RuntimeValue = true;
        return base.MakeSentence();
    }
}
