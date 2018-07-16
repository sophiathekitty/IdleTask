using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/World")]
public class StoryLocationWorld : ScriptableObject {
    public List<StoryLocation> locations;
}
