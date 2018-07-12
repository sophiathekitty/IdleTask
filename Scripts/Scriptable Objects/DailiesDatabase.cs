using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailiesDatabase : SavableVariable, ISerializationCallbackReceiver
{
    [System.NonSerialized]
    public List<DailyModel> dailies = new List<DailyModel>();

    public void OnAfterDeserialize()
    {
        // apply any defaults.... none now i guess.....
    }

    public void OnBeforeSerialize() { /* do nothing */ }

    public override void OnClearSave()
    {
        dailies.Clear();
    }

    public override void OnLoadData(string data)
    {
        dailies.Clear();
        string[] ds = data.Split('|');
        foreach (string d in ds)
            dailies.Add(new DailyModel(d));
    }

    public override string OnSaveData()
    {
        string data = "";
        if (dailies.Count > 0)
            data = dailies[0].ToString();
        for (int i = 1; i < dailies.Count; i++)
            data += "|" + dailies[i].ToString();
        return data;
    }
}
