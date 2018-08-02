using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelectList : MonoBehaviour {
    public CharSpriteLib lib;
    public GameObject prefab;
	// Use this for initialization
	void Start () {
		for(int i = 0; i < lib.chars.Length; i++)
        {
            GameObject charObject = GameObject.Instantiate(prefab, transform);
            CharSelectBtn btn = charObject.GetComponent<CharSelectBtn>();
            btn.index = i;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
