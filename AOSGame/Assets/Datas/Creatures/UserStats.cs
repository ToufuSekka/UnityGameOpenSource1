using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserStats : MonoBehaviour{
    public Dictionary<StatTag, int> CombatableStat = new Dictionary<StatTag, int>();
    public Dictionary<StatTag, float> Survivable= new Dictionary<StatTag, float>();
    public Dictionary<StatTag, int> GrowableStat = new Dictionary<StatTag, int>();

    GameObject t;
    private void Start() {
        statINIT();
        StatInserter();
    }

    void statINIT() {
        for (int i =0;i < 0x10 ;i++) {

            if (Enum.IsDefined(typeof(StatTag), i)) {
                CombatableStat.Add((StatTag) i, 10);
                Debug.Log("Complete : CombatableStat =>" + i);
            }

            if (Enum.IsDefined(typeof(StatTag), i + 0x10)) {
                Survivable.Add((StatTag) i + 0x10, 10);
                Debug.Log("Complete : Survivable =>" + i);
            }
            if (Enum.IsDefined(typeof(StatTag), i + 0x20)) {
                GrowableStat.Add((StatTag) i + 0x20, 10);
                Debug.Log("Complete : GrowableStat =>" + i);
            }
            Debug.Log(i);
        }
    }

    void StatInserter() {
        string trs = CombatableStat[];
        Debug.Log(trs);
        /*
        t = GameObject.Find("Stat1");
        t.transform.GetChild(0).GetComponent<Text>().text= trs;
        t.transform.GetChild(1).GetComponent<Text>().text = "5";
        */
    }
}
