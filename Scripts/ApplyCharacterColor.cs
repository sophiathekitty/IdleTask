using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ApplyCharacterColor : MonoBehaviour {

    public Character character;
    private TextMeshProUGUI textMesh;
    private Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        textMesh = GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update () {
        if (text != null) text.color = character.color;
        if (textMesh != null) textMesh.color = character.color;
	}
}
