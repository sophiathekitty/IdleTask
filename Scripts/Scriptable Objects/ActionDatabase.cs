using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionDatabase : SavableVariable {
     


    public override void OnClearSave()
    {
        throw new System.NotImplementedException();
    }

    public override void OnLoadData(string data)
    {
        throw new System.NotImplementedException();
    }

    public override string OnSaveData()
    {
        throw new System.NotImplementedException();
    }

    public struct ADEntry
    {
        public string title;
        public int count;
        public string icon;
    }
}
