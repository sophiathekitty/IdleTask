using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Story/Sentence", fileName ="Sentence")]
public class StoryLine : ScriptableObject {
    public string sentence; // $player searched the area and found, $reward
    public MadLib[] madlibs;
    public AudioClip clip;
    public float cost = 1;
    public virtual string MakeSentence()
    {
        string s = sentence;
        foreach (MadLib r in madlibs)
            s = s.Replace(r.search, r.Replace);
        return s;
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