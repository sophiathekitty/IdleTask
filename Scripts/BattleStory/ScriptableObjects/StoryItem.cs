using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Item")]
public class StoryItem : ScriptableObject {
    public string article;
    public string display_name;
    public string DisplayName
    {
        get
        {
            if (article == "")
                return display_name;

            return article + " " + display_name;
        }
    }
    public string DisplayNameColored
    {
        get
        {
            string item_name = "<color=#" + ColorUtility.ToHtmlStringRGB(color) + ">" + display_name + "</color>";
            if (article == "")
                return item_name;
            

            return article + " " + item_name;
        }
    }
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
