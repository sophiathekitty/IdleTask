using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GridLayoutGroup))]
public class ActionGrid : MonoBehaviour {
    public GameObject actionPrefab;
    public ActionLevelManager levels;
    public ActionIconManager icons;
    public ActionDatabase database;
    // Use this for initialization
    void Start () {
        // load the actions
        foreach (ActionModel action in database.actions)
            AddAction(action);
        // spawn a bunch of buttons
        /*
        for (int i = 0; i < 100; i++)
        {
            GameObject actionButtonObject = GameObject.Instantiate(actionPrefab, transform);
            ActionButton actionButton = actionButtonObject.GetComponent<ActionButton>();
            actionButton.level = levels.levels[Random.Range(0, levels.levels.Length - 1)];
            actionButton.text.text = RandomWord();
            actionButton.icon.sprite = icons.icons[Random.Range(0, icons.icons.Count - 1)];
        }
        */
	}

    public void AddAction(ActionModel action)
    {
        GameObject actionButtonObject = GameObject.Instantiate(actionPrefab, transform);
        ActionButton actionButton = actionButtonObject.GetComponent<ActionButton>();
        Debug.Log(action.level + " / " + levels.levels.Length);
        actionButton.level = levels.levels[action.level];
        actionButton.text.text = action.name;
        actionButton.icon.sprite = icons.icons[action.icon];
        actionButton.model = action;
        actionButton.database = database;
        actionButton.click_count = action.clicks;
    }

    string RandomWord()
    {
        string[] words = {"Drink Water", "Eat Breakfast", "Cleaning", "Spike", "Orion", "Coding", "Watch TV", "Eat Lunch", "Cook Dinner", "Music" };
        return words[Random.Range(0, words.Length - 1)];
    }
	
	// Update is called once per frame
	void Update () {
	}
}
