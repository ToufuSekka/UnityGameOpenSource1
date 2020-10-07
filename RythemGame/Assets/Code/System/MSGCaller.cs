using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MSGCaller : MonoBehaviour{
    GameObject[] MSGVr;

    void caller(string[] contants) {
        if (contants.Length !=2) return;

        MSGVr = new GameObject[3];
        MSGVr[0] = Resources.Load("UI/SysMSGView") as GameObject;

        for (int e = 1; e < 3; e++) {
            MSGVr[e] = MSGVr[0].transform.GetChild(e).GetChild(0).gameObject;
            MSGVr[e].GetComponent<Text>().text = contants[e - 1];
        }
        Instantiate(MSGVr[0]);
    }
}