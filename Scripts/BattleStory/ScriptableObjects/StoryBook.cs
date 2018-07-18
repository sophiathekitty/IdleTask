using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Book")]
public class StoryBook : ScriptableObject {
    public StoryLine storyLine;
    public List<StoryLine> storyLines = new List<StoryLine>();

    public StoryLine GetStoryLine(ActionLevel action)
    {
        List<StoryLine> validLines = new List<StoryLine>();
        foreach (StoryLine line in storyLines)
            if (line.CanDo)
                validLines.Add(line);

        if (validLines.Count > 0)
            return validLines[Random.Range(0, validLines.Count)];
        // return default
        return storyLine;
    }

}
