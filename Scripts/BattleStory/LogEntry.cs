using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogEntry : MonoBehaviour {
    public TextMeshProUGUI time_txt;
    public TextMeshProUGUI sentence_txt;
    private RectTransform rectTransform;



	// Use this for initialization
	void Start () {
        rectTransform = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(rectTransform.rect.height);
        rectTransform.sizeDelta.Set(rectTransform.sizeDelta.x, sentence_txt.renderedHeight + 2);
	}
}
