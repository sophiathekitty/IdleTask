using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Action Database")]
public class ActionDatabase : SavableVariable, ISerializationCallbackReceiver {
    [System.NonSerialized]
    public List<ActionModel> actions = new List<ActionModel>();

    public List<ActionModel> defaults = new List<ActionModel>();

    public void OnAfterDeserialize()
    {
        foreach (ActionModel action in defaults)
            if (!actions.Contains(action))
            {
                actions.Add(action);
                action.clicks = 0;
            }
                
    }

    public void OnBeforeSerialize()
    {
        /* do nothing */
    }

    public override void OnClearSave()
    {
        actions.Clear();
    }

    public override void OnLoadData(string data)
    {
        
        actions.Clear();
        string[] dateData = data.Split('}');
        bool resetStreak = (dateData[0] != System.DateTime.Today.ToShortDateString());

        string[] ams = dateData[1].Split('|');
        foreach (string am in ams)
            if (am != "")
                actions.Add(new ActionModel(am));

        for (int i = 0; i < actions.Count; i++)
        {
            actions[i].index = i;
            if (resetStreak)
                actions[i].clicks = 0;
        }
            
    }

    public override string OnSaveData()
    {
        string data = System.DateTime.Today.ToShortDateString() + "}";
        foreach(ActionModel am in actions)
        {
            data += am.ToString() + "|";
        }
        return data;
    }
}
