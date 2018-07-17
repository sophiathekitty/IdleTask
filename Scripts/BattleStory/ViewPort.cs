using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewPort : MonoBehaviour {
    public StoryLocationWorld world;
    public IntVariable locationIndex;
    public BoolVariable inBattle;

    public Image background;

    public GameObject playerWalking;
    public GameObject playerFighting;
    public GameObject enemyFighting;
    public GameObject enemyStats;

	// Use this for initialization
	void Start () {
        if(background == null)
            background = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        background.sprite = world.locations[locationIndex.RuntimeValue].background;
        playerWalking.SetActive(!inBattle.RuntimeValue);
        playerFighting.SetActive(inBattle.RuntimeValue);
        enemyFighting.SetActive(inBattle.RuntimeValue);
        enemyStats.SetActive(inBattle.RuntimeValue);
	}
}
