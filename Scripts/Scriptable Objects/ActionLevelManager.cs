using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Manager")]
public class ActionLevelManager : ScriptableObject {
    public ActionLevel[] levels;
    public int LevelIndex(string lvl)
    {
        int i = 0;
        Debug.Log(lvl);
        foreach(ActionLevel level in levels)
        {
            if (level.name == lvl)
                return i;
            i++;
        }
        Debug.Log("oh shit it didn't find the level");
        return 0;
    }
}
