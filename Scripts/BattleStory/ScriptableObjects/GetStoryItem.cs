using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Get Item", fileName = "Get Item")]
public class GetStoryItem : StoryLine {
    public StoryItem[] items;
    [Range(0f, 1f)]
    public float successRate;

    public override string MakeSentence()
    {
        string item_name = "$nothing";
        string sent = base.MakeSentence();
        if (Random.Range(0f,1f) < successRate)
        {
            // give player an item
            StoryItem storyItem = items[Random.Range(0, items.Length - 1)];
            storyItem.playerOwns++;
            item_name = storyItem.DisplayNameColored;
        }
        sent = sent.Replace("$item", item_name);
        foreach (MadLib r in madlibs)
            sent = sent.Replace(r.search, r.Replace);
        sent = sent.Replace("$nothing", "nothing");
        return sent;
    }

}
