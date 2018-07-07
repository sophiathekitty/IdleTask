using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;

public class BattleStoryTests  {
    [UnityTest]
    public IEnumerator ActionDatabase_save_load()
    {
        ActionModel testData = new ActionModel
        {
            name = "testing"
        };
        ActionDatabase test = ScriptableObject.CreateInstance<ActionDatabase>(); // new ActionDatabase();
        test.actions.Add(testData);
        test.OnLoadData(test.OnSaveData());
        yield return null;

        Assert.AreEqual(testData.name, test.actions[0].name);
    }
}
