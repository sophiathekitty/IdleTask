using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddActionBtn : MonoBehaviour {
    public GameObject form;
    
    public void ShowForm()
    {
        if (form != null)
            form.SetActive(true);
    }

	// Update is called once per frame
	void Update () {
        transform.SetAsLastSibling();
	}
}
