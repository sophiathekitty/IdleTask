using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AddActionForm : MonoBehaviour {
    public TMP_Dropdown dailiesList;
    public TMP_Dropdown levelsList;

    public ActionLevelManager actionLevelManager;

    // Use this for initialization
    void Start () {
        levelsList.ClearOptions();
        List<string> options = new List<string>();
        foreach (ActionLevel level in actionLevelManager.levels)
            options.Add(level.name);
        levelsList.AddOptions(options);
	}
	

    public void SaveAction()
    {

        gameObject.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
