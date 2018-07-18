using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NewPlayerForm : MonoBehaviour {

    public TMP_InputField playerName;
    public TMP_Dropdown playerPronouns;

    public SaveObject saveObject;
    public Character player;

    public void CreatePlayer()
    {
        Debug.Log(playerName.text);
        Debug.Log(playerPronouns.value);

        player.full_name.RuntimeValue = player.short_name.RuntimeValue = playerName.text;
        switch (playerPronouns.value)
        {
            case 1:
                player.they.RuntimeValue =      "she";
                player.their.RuntimeValue =     "her";
                player.them.RuntimeValue =      "her";
                player.theirs.RuntimeValue =    "hers";
                player.themself.RuntimeValue =  "herself";
                break;
            case 2:
                player.they.RuntimeValue =      "he";
                player.their.RuntimeValue =     "his";
                player.them.RuntimeValue =      "him";
                player.theirs.RuntimeValue =    "his";
                player.themself.RuntimeValue =  "himself";
                break;
        }
        if (player.short_name.RuntimeValue != player.short_name.InitialValue)
            gameObject.SetActive(false);
    }

    // Use this for initialization
    void Start () {
        saveObject.LoadData();
        if (player.short_name.RuntimeValue != player.short_name.InitialValue)
            gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
