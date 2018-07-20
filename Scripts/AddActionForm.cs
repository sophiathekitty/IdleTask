using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AddActionForm : MonoBehaviour {
    public TMP_InputField nameTxt;
    public TMP_Dropdown dailiesList;
    public TMP_Dropdown levelsList;
    public ActionIconManager icons;
    public ActionLevelManager actionLevelManager;

    public ActionGrid currentGrid;
    public ActionDatabase database;

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

        ActionModel action = new ActionModel
        {
            name = nameTxt.text,
            icon = icons.selected,
            level = levelsList.value
        };
        currentGrid.AddAction(action);
        database.actions.Add(action);

        for (int i = 0; i < database.actions.Count; i++)
            database.actions[i].index = i;


        gameObject.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
