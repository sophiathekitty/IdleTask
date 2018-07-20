using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TMP_AutoHeight : MonoBehaviour {
    public TextMeshProUGUI textMesh;
    private RectTransform rectTransform;
    public float heightPadding = 5f;

	// Use this for initialization
	void Start () {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(rectTransform.rect.width, textMesh.preferredHeight + heightPadding);
    }

    // Update is called once per frame
    void Update () {
        rectTransform.sizeDelta = new Vector2(rectTransform.rect.width, textMesh.preferredHeight + heightPadding);
    }
}
