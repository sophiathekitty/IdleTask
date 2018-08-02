using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Story/Characters/CharSprites")]
public class CharSprites : ScriptableObject {
    public Sprite sprite;
    public Sprite[] walking;
    public Sprite[] fighting;

    int index_w;
    int index_f;

    public Sprite GetWalking
    {
        get
        {
            index_w++;
            if (index_w >= walking.Length) index_w = 0;
            Debug.Log("walking: " + index_w + "/" + walking.Length);
            return walking[index_w];
        }
    }
    public Sprite GetFighting
    {
        get
        {
            index_f++;
            if (index_f >= fighting.Length) index_f = 0;
            Debug.Log("fighting: " + index_f + "/" + fighting.Length);
            return fighting[index_f];
        }
    }
}
