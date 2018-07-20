using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Book")]
public class StoryBook : ScriptableObject {
    public StoryLine storyLine;
    public List<StoryLine> storyLines = new List<StoryLine>();

    public StoryLine GetStoryLine(bool fallbackToDefault = false)
    {
        // find valid sentences
        List<StoryLine> validLines = new List<StoryLine>();
        foreach (StoryLine line in storyLines)
            if (line.CanDo)
                validLines.Add(line);
        // return a valid sentence
        if (validLines.Count > 0)
            return validLines[Random.Range(0, validLines.Count)];
    
        // return default
        if(fallbackToDefault)
            return storyLine;

        return null;
    }

}
