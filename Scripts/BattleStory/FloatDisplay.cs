using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FloatDisplay : MonoBehaviour {
    public FloatVariable floatVariable;
    public string text_format = "$value";
    private TextMeshProUGUI text_tmp;
    private Text text;

    // Use this for initialization
    void Start()
    {
        text_tmp = GetComponent<TextMeshProUGUI>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (floatVariable == null)
            throw new System.NullReferenceException(name + " missing float variable");

        if (text != null)
            text.text = DisplayText();
        if (text_tmp != null)
            text_tmp.text = DisplayText();
    }

    private string DisplayText()
    {
        return text_format.Replace("$value", Mathf.Round(floatVariable.RuntimeValue).ToString());
    }
}
