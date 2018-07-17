using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Use Item", fileName = "Use Item")]
public class UseStoryItem : StoryLine {
    public StoryItem item;
    public override bool CanDo
    {
        get
        {
            if (item.attributeVariable != null  // if item changes an attribute
                && item.attrMaxChange == 0)    // though if it adds more
                return (item.attributeVariable.RuntimeValue + item.valueChange < item.attributeVariable.RuntimeMax 
                        || item.attributeVariable.RuntimeMax > item.valueChange)
                    && base.CanDo;
            return base.CanDo;
        }
    }
}
