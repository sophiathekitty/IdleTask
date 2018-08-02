using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharDisplay : MonoBehaviour {
    public CharSpriteLib lib;
    public IntVariable index;
    public bool fighting;
    public float rate = 1f;
    float rateTime = 0f;
    Image image;
	// Use this for initialization
	void Start () {
        image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        if(rateTime >= 0f)
        {
            rateTime -= Time.deltaTime;
            return;
        }
        Debug.Log("update sprite");
        rateTime = rate;

        if(fighting)
            image.sprite = lib.chars[index.RuntimeValue].GetFighting;
        else
            image.sprite = lib.chars[index.RuntimeValue].GetWalking;
    }
}
