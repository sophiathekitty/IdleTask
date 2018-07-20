using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Change Location", fileName = "ChangeLocation")]
public class ChangeLocation : StoryLine {
    public StoryLocation location;
    public IntVariable locationIndex;

    public override bool CanDo
    {
        get
        {
            bool isNeighbor = false;
            foreach (StoryLocation n in location.neighbors)
                if (locationIndex.RuntimeValue == n.index)
                    isNeighbor = true;
//            Debug.Log("Change Location: " + location.display_name + " " + isNeighbor.ToString() + " " + base.CanDo.ToString() + " " + (base.CanDo && isNeighbor).ToString());
            return (base.CanDo && isNeighbor);
        }
    }
    public override string MakeSentence()
    {
        string sent = base.MakeSentence();
        sent = sent.Replace("$location", location.display_name);
        locationIndex.RuntimeValue = location.index;
        return sent;
    }
}
