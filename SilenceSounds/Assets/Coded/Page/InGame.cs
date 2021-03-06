﻿using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class InGame : MonoBehaviour{
    DATACNTL datact = new DATACNTL();
    AUDCNTL audct = new AUDCNTL();
    BTNCNTL btnct = new BTNCNTL();

    readonly string nulla ="NullData;NullData";
    string[] sorter;
    string chapName;
    int r = -1;

    //callBack
    private void Start() {
        DataPather.realData.Add(GameObject.Find("Name_Text"));
        DataPather.realData.Add(GameObject.Find("Log_Text"));
        DataPather.realData.Add(GameObject.Find("BGI"));

        chapName = DataPather.ChapterSaver;
    }

    void Update(){
        if (Input.GetMouseButtonDown(0)) {
            Outputs(true);
        }

        if (Input.GetMouseButtonDown(1)) {
            Outputs(false);
        }
    }

    //customFunc
    private void Outputs(bool set) {
        do {
            if (set)
                r++;
            else
                r--;
            sorter = datact.DataSecondSort(chapName, r);
            datact.DataFirstSort(sorter);
            //Debug.Log(r + " " + sorter[2]);
        } while (!sorter[0].Equals("logger") || sorter[1].Equals("break"));

        if (sorter[2].Equals(nulla)) {
            if (set)
                r--;
            else
                r++;
        }
    }
}
