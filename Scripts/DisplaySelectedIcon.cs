using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySelectedIcon : MonoBehaviour {
    private Image icon;
    public ActionIconManager icons;
	// Use this for initialization
	void Start () {
        icon = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        icon.sprite = icons.SelectedSprite;
	}
}
