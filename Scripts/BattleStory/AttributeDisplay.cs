using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AttributeDisplay : MonoBehaviour {
    public AttributeVariable attribute;
    public string text_format = "$value/$max";
    public bool unavialable;
    private TextMeshProUGUI text_tmp;
    private Text text;
    private Image bar;

	// Use this for initialization
	void Start () {
        text_tmp = GetComponent<TextMeshProUGUI>();
        text = GetComponent<Text>();
        bar = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        if (attribute == null)
            throw new System.NullReferenceException(name+" missing attribute");

        if (text != null)
            text.text = DisplayText();
        if (text_tmp != null)
            text_tmp.text = DisplayText();


        if (bar != null && !float.IsNaN(Percent))
            bar.transform.localScale = new Vector3(Percent, 1, 1);
	}
    
    private float Percent
    {
        get
        {
            if (unavialable)
                return attribute.RuntimeUnavailable / attribute.RuntimeMax;
            return attribute.Percent;
        }
    }

    private string DisplayText()
    {
        string txt = "";
        if(unavialable)
            txt = text_format.Replace("$value", Mathf.Round(attribute.RuntimeUnavailable).ToString());
        else
            txt = text_format.Replace("$value", Mathf.Round(attribute.RuntimeValue).ToString());
        txt = txt.Replace("$max", Mathf.Round(attribute.RuntimeMax).ToString());
        return txt;
    }
}
