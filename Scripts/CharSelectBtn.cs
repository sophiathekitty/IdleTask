using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharSelectBtn : MonoBehaviour {
    public int index;
    public IntVariable selectIndex;
    public CharSpriteLib lib;
    public Image charSprite;
    private Image select;

    public Color selectColor;
    public Color defaultColor;
    
	// Use this for initialization
	void Start () {
        select = GetComponent<Image>();
	}
    void Update()
    {
        charSprite.sprite = lib.chars[index].sprite;
        if (selectIndex.RuntimeValue == index)
            select.color = selectColor;
        else
            select.color = defaultColor;
    }

    public void SelectMe()
    {
        selectIndex.RuntimeValue = index;
    }

}
