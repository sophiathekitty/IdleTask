using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Location")]
public class StoryLocation : ScriptableObject {
    public int index;
    public string display_name;
    public Sprite background;
    public List<StoryLocation> neighbors;
    public List<StoryItem> hiddenItems;
}
