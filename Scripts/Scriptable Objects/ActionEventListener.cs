using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionEventListener : MonoBehaviour {
    public ActionEvent Event;
    public StoryLine storyLine;
    public StoryEvent Response;
    public AttributeVariable playerExperience;
    public FloatVariable actionPoints;

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
        return storyLine;
    }


    [System.Serializable]
    public class StoryEvent : UnityEvent<StoryLine> { }
}
