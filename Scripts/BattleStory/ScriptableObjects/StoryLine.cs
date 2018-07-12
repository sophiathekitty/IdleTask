using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Story/Sentence", fileName ="Sentence")]
public class StoryLine : ScriptableObject {
    public string sentence; // $player searched the area and found, $reward
    public MadLib[] madlibs;
    public AudioClip clip;
    public float cost = 1;
    public Character player;
    public Character enemy;
    public FloatVariable actionPoints;
    public virtual string MakeSentence()
    {
        string s = sentence;
        foreach (MadLib r in madlibs)
            s = s.Replace(r.search, r.Replace);
        if(actionPoints != null)
            actionPoints.RuntimeValue -= cost;
        s = s.Replace("$player", "<b><color=#" + ColorUtility.ToHtmlStringRGB(player.color) + ">" + player.full_name.RuntimeValue + "</color></b>");
        s = s.Replace("$enemy", "<b><color=#" + ColorUtility.ToHtmlStringRGB(enemy.color) + ">" + enemy.full_name.RuntimeValue + "</color></b>");
        Debug.Log(player.full_name.RuntimeValue);
        return s;
    }
    public virtual bool CanDo
    {
        get
        {
            if (actionPoints == null)
                return true;

            return actionPoints.RuntimeValue > cost;
        }
    }

    [System.Serializable]
    public class MadLib
    {
        public string search;
        public string[] replaces;
        public string Replace
        {
            get
            {
                if(replaces.Length > 1)
                    return replaces[Random.Range(0,replaces.Length-1)];
                return "";
            }
        }
    }
}