using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureLog : MonoBehaviour {
    public GameObject entryPrefab;

    // Use this for initialization
    void Start () {
        //for (int i = 0; i < 100; i++)
        //    AddEntry(storyLines[Random.Range(0, storyLines.Length - 1)]);
    }


    public void AddEntry(StoryLine sentence)
    {
        GameObject entryObject = GameObject.Instantiate(entryPrefab, transform);
        LogEntry entry = entryObject.GetComponent<LogEntry>();
        entry.time_txt.text = System.DateTime.Now.ToShortTimeString();
        entry.sentence_txt.text = sentence.MakeSentence();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
