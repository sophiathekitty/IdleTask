using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DailyModel
{
    public string name;
    public List<int> actions = new List<int>();

    public DailyModel() { }
    public DailyModel(string data)
    {
        string[] parts = data.Split(',');
        name = parts[0];
        for (int i = 1; i < parts.Length; i++)
            actions.Add(int.Parse(parts[i]));
    }
    public override string ToString()
    {
        string data = name;
        foreach (int action in actions)
            data += "," + action;
        return data;
    }
}
