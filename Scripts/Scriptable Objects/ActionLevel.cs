using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Level")]
public class ActionLevel : ScriptableObject {
    public Color background;
    public Color text;
    public Color cooldown;
    public float cooldownTime;
    public AudioClip sound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
