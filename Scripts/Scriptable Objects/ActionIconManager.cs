using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/IconManager")]
public class ActionIconManager : ScriptableObject {
    public List<Sprite> icons;
    public int selected = 0;

    public Sprite SelectedSprite
    {
        get
        {
            if (selected >= icons.Count)
                return icons[0];
            return icons[selected];
        }
    }
}
