using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryItem : ScriptableObject {
    public string display_name;
    public Color color;
    public Sprite icon;
    public AttributeVariable attributeVariable;
    public FloatVariable floatVariable;
    public float valueChange;
    public float attrMaxChange;

    public void UseItem()
    {
        if (floatVariable != null)
            floatVariable.RuntimeValue += valueChange;
        if(attributeVariable != null)
        {
            attributeVariable.RuntimeValue += valueChange;
            attributeVariable.RuntimeMax += attrMaxChange;
        }
    }
}
