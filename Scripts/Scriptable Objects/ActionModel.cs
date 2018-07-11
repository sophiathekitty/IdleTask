using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ActionModel {
    public string name;
    public int daily;
    public int level;
    public int icon;
    public int clicks;

    public ActionModel() { }
    public ActionModel(string data)
    {
        string[] parts = data.Split(',');
        name = parts[0];
        daily = int.Parse(parts[1]);
        icon = int.Parse(parts[2]);
        level = int.Parse(parts[3]);
        clicks = int.Parse(parts[4]);
    }

    public override string ToString()
    {
        return name + ","
            + daily.ToString() + "," 
            + level.ToString() + "," 
            + icon.ToString() + "," 
            + clicks.ToString();
    }
}
