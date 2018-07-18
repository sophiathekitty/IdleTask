using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ActionEventListener : MonoBehaviour {
    public ActionEvent Event;
    public StoryLine storyLine;
    public StoryLine[] storyLines;
    public StoryBook storyBook;
    public StoryEvent Response;
    public Image locationBack;
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
        StoryLine cStoryLine = storyBook.GetStoryLine(action);
        /*
        // is this a change of location?
        ChangeLocation cLocation = cStoryLine as ChangeLocation;
        if (cLocation != null)
            locationBack.sprite = cLocation.location.background;
            */
        Response.Invoke(cStoryLine);
    }

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


    [System.Serializable]
    public class StoryEvent : UnityEvent<StoryLine> { }
}
