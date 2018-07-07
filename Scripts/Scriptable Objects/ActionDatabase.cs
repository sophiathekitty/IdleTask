using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Action Database")]
public class ActionDatabase : SavableVariable, ISerializationCallbackReceiver {
    public List<ActionModel> actions = new List<ActionModel>();

    public List<ActionModel> defaults = new List<ActionModel>();

    public void OnAfterDeserialize()
    {
        foreach (ActionModel action in defaults)
            if (!actions.Contains(action))
                actions.Add(action);
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
        string[] ams = data.Split('|');
        foreach (string am in ams)
            if (am != "")
                actions.Add(new ActionModel(am));
                
    }

    public override string OnSaveData()
    {
        string data =  "";
        foreach(ActionModel am in actions)
        {
            data += am.ToString() + "|";
        }
        return data;
    }
}
