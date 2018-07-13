using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variables/Story Inventory")]
public class StoryInventory : SavableVariable, ISerializationCallbackReceiver
{
    // stores all the possible items.... items have a playerOwns value.... that's how we know they has the item...
    public List<StoryItem> items = new List<StoryItem>();
    
    public void OnAfterDeserialize()
    {
        /* load defaults */
    }

    public void OnBeforeSerialize() { /* do no thing */ }

    public override void OnClearSave()
    {
        for(int i = 0; i < items.Count; i++)
        {
            items[i].playerOwns = 0;
        }
    }

    public override void OnLoadData(string data)
    {
        string[] ds = data.Split('|');
        for(int i = 0; i < ds.Length; i++)
        {
            string[] kv = ds[i].Split(',');
            if (kv[0] == items[i].GetInstanceID().ToString())
                items[i].playerOwns = int.Parse(kv[1]);
            else
                LoadItemsByID(int.Parse(kv[0]), int.Parse(kv[1]));
        }
    }

    // in case the list of items has changed.... would suck to lose all the items...
    void LoadItemsByID(int id, int value)
    {
        foreach(StoryItem itm in items)
        {
            if(itm.GetInstanceID() == id)
            {
                itm.playerOwns = value;
                return;
            }

        }
    }

    public override string OnSaveData()
    {
        string data = "";
        if(items.Count > 0)
        {
            data = items[0].GetInstanceID().ToString() + "," + items[0].playerOwns.ToString();
        }

        for(int i = 1; i < items.Count; i++)
            data += "|" + items[i].GetInstanceID().ToString() + "," + items[i].playerOwns.ToString();

        return data;
    }
}
