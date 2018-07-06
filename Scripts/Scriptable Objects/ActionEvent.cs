using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/ActionEvent")]
public class ActionEvent : ScriptableObject {
    private List<ActionEventListener> listeners = new List<ActionEventListener>();
    public void Raise(ActionLevel action)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised(action);
        }
    }

    public void RegisterListener(ActionEventListener listener)
    {
        if (!listeners.Contains(listener))
            listeners.Add(listener);
    }
    public void UnregisterListener(ActionEventListener listener)
    {
        if (listeners.Contains(listener))
            listeners.Remove(listener);
    }
}
