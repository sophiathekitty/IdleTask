using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Story/Sentence", fileName ="Sentence")]
public class StoryLine : ScriptableObject {
    public string sentence; // $player searched the area and found, $reward
    public MadLib[] madlibs;
    public float cost = 1;
    public Character player;
    public Character enemy;
    public FloatVariable actionPoints;
    public BoolVariable isInBattle;
    public bool battle;

    public string ApplyMadLib(string s)
    {
        foreach (MadLib r in madlibs)
            s = s.Replace(r.search, r.Replace);
        s = s.Replace("$player", "<b><color=#" + ColorUtility.ToHtmlStringRGB(player.color) + ">" + player.full_name.RuntimeValue + "</color></b>");
        s = s.Replace("$their", "<b><color=#" + ColorUtility.ToHtmlStringRGB(player.color) + ">" + player.their.RuntimeValue + "</color></b>");
        s = s.Replace("$theirs", "<b><color=#" + ColorUtility.ToHtmlStringRGB(player.color) + ">" + player.theirs.RuntimeValue + "</color></b>");
        s = s.Replace("$them", "<b><color=#" + ColorUtility.ToHtmlStringRGB(player.color) + ">" + player.them.RuntimeValue + "</color></b>");
        s = s.Replace("$they", "<b><color=#" + ColorUtility.ToHtmlStringRGB(player.color) + ">" + player.they.RuntimeValue + "</color></b>");

        s = s.Replace("$enemy", "<b><color=#" + ColorUtility.ToHtmlStringRGB(enemy.color) + ">" + enemy.full_name.RuntimeValue + "</color></b>");
        return s;
    }
    public virtual string MakeSentence()
    {
        if (actionPoints != null)
            actionPoints.RuntimeValue -= cost;

        return ApplyMadLib(sentence);
        /*
        string s = sentence;
        foreach (MadLib r in madlibs)
            s = s.Replace(r.search, r.Replace);
        s = s.Replace("$player", "<b><color=#" + ColorUtility.ToHtmlStringRGB(player.color) + ">" + player.full_name.RuntimeValue + "</color></b>");
        s = s.Replace("$their", "<b><color=#" + ColorUtility.ToHtmlStringRGB(player.color) + ">" + player.their.RuntimeValue + "</color></b>");
        s = s.Replace("$theirs", "<b><color=#" + ColorUtility.ToHtmlStringRGB(player.color) + ">" + player.theirs.RuntimeValue + "</color></b>");
        s = s.Replace("$them", "<b><color=#" + ColorUtility.ToHtmlStringRGB(player.color) + ">" + player.them.RuntimeValue + "</color></b>");
        s = s.Replace("$they", "<b><color=#" + ColorUtility.ToHtmlStringRGB(player.color) + ">" + player.they.RuntimeValue + "</color></b>");

        s = s.Replace("$enemy", "<b><color=#" + ColorUtility.ToHtmlStringRGB(enemy.color) + ">" + enemy.full_name.RuntimeValue + "</color></b>");
        return s;
        */
    }
    public virtual bool CanDo
    {
        get
        {
            // some actions can only happen in or out of battle.... some probably don't care....
            if (isInBattle != null && isInBattle.RuntimeValue != battle)
                return false;

            // if there's no action points to check against i guess we can do this by default.....
            if (actionPoints == null)
                return true;

            return actionPoints.RuntimeValue > cost;
        }
    }
    /// <summary>
    /// MadLibs.... like the classic pick a word..... bonus you can do more complex things than that....
    /// $keyword -> sentance fragments to be randomly selected
    /// </summary>
    [System.Serializable]
    public class MadLib
    {
        public string search;       // type_of_animal
        public string[] replaces;   // dog, cat, wolf, monkey, bear, rat
        public string Replace
        {
            get
            {
                // just grab one of the replace options and send it on it's way....
                if (replaces.Length > 1)
                    return replaces[Random.Range(0,replaces.Length-1)];
                // really..... shouldn't ever happen but no point breaking over that....
                return "";
            }
        }
    }
}