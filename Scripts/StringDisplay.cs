using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StringDisplay : MonoBehaviour {

    public StringVariable stringVariable;
    private TextMeshProUGUI textMesh;
    private Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        textMesh = GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update () {
        if (text != null)
            text.text = stringVariable.RuntimeValue;
        if (textMesh != null)
            textMesh.text = stringVariable.RuntimeValue;
	}
}
