using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GridLayoutGroup))]
public class ActionGrid : MonoBehaviour {
    public GameObject actionPrefab;
    public ActionLevel[] level;
    public Sprite[] sprites;

    // Use this for initialization
    void Start () {
        // spawn a bunch of buttons
        for (int i = 0; i < 100; i++)
        {
            GameObject actionButtonObject = GameObject.Instantiate(actionPrefab, transform);
            ActionButton actionButton = actionButtonObject.GetComponent<ActionButton>();
            actionButton.level = level[Random.Range(0, level.Length - 1)];
            actionButton.text.text = RandomWord();
            actionButton.icon.sprite = sprites[Random.Range(0, sprites.Length)];
        }
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
