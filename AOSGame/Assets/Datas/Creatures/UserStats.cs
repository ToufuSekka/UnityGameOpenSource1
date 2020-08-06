using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserStats : MonoBehaviour{
    public Dictionary<StatTag, float> Survivable = new Dictionary<StatTag, float>();
    public Dictionary<StatTag, int> CombatableStat = new Dictionary<StatTag, int>();
    public Dictionary<StatTag, int> GrowableStat = new Dictionary<StatTag, int>();

    GameObject t;
    private void Start() {
        statINIT();
        //StatInserter();
    }

    void statINIT() {
        for (int i =0;i < 0x10 ;i++) {

            if (Enum.IsDefined(typeof(StatTag), i))
                Survivable.Add((StatTag) i, 10);
           
            if (Enum.IsDefined(typeof(StatTag), i + 0x10))
                CombatableStat.Add((StatTag) i + 0x10, 10);
           
            if (Enum.IsDefined(typeof(StatTag), i + 0x20))
                GrowableStat.Add((StatTag) i + 0x20, 10);
        }
    }

    void CallStatter() {
        int a = 0;
        switch(a){
            default: break;
        }
        t = GameObject.Find("StatViewer");
    }
    void StatInserter() {
        t = GameObject.Find("Stat1");
        foreach (var data in CombatableStat) {
            t.transform.GetChild(0).GetComponent<Text>().text = data.Key.ToString();
            t.transform.GetChild(1).GetComponent<Text>().text = data.Value.ToString();
            Debug.Log(data.Key +" : "+ data.Value);
        }
    }
}
