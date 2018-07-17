using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/World")]
public class StoryLocationWorld : ScriptableObject, ISerializationCallbackReceiver
{
    public List<StoryLocation> locations;

    public void OnAfterDeserialize()
    {
        for (int i = 0; i < locations.Count; i++)
            locations[i].index = i;
    }

    public void OnBeforeSerialize()
    {
        /* do nothing */
    }
}
