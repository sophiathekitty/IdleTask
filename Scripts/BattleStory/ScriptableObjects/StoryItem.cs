using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Item")]
public class StoryItem : ScriptableObject {
    public string display_name;
    public Color color;
    public Sprite icon;
    public AttributeVariable attributeVariable;
    public FloatVariable floatVariable;
    public float valueChange;
    public float attrMaxChange;
    [System.NonSerialized]
    public int playerOwns;

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
