using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionEventListener : MonoBehaviour {
    public ActionEvent Event;
    public StoryLine storyLine;
    public StoryLine[] storyLines;
    public StoryEvent Response;
    //public AttributeVariable playerExperience;
    //public FloatVariable actionPoints;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }
    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(ActionLevel action)
    {
        Response.Invoke(GetStoryLine(action));
    }

    public StoryLine GetStoryLine(ActionLevel action)
    {
        List<StoryLine> validLines = new List<StoryLine>();
        foreach (StoryLine line in storyLines)
            if (line.CanDo)
                validLines.Add(line);
        
        if (validLines.Count > 0)
            return validLines[Random.Range(0, validLines.Count - 1)];
        // return default
        return storyLine;
    }


    [System.Serializable]
    public class StoryEvent : UnityEvent<StoryLine> { }
}
