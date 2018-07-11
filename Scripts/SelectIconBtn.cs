using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectIconBtn : MonoBehaviour {
    public ActionIconManager icons;
    public int index;

	public void IconSelected()
    {
        icons.selected = index;
    }
}
