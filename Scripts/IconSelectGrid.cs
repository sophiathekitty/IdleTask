using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconSelectGrid : MonoBehaviour {
    public ActionIconManager icons;
    public GameObject prefab;
	// Use this for initialization
	void Start () {
        int i = 0;
		foreach(Sprite icon in icons.icons)
        {
            GameObject iconButtonObject = GameObject.Instantiate(prefab, transform);
            SelectIconBtn iconButton = iconButtonObject.GetComponent<SelectIconBtn>();
            iconButton.index = i; i++;
            Image sprite = iconButtonObject.GetComponent<Image>();
            sprite.sprite = icon;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
