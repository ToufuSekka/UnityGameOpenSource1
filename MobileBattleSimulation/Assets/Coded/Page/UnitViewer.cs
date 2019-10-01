using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitViewer : MonoBehaviour{

    DatCntl DATC = new DatCntl();
    GameObject go;
    int x = 1;

    //CallBack
    private void Start() {
        foreach (string Name in DATC.Viewing("")) {
            go = Instantiate(Resources.Load("UIData/NormalUnitView"), GameObject.Find("UnitViewr").transform) as GameObject;
            go.name = Name;
            go.GetComponent<UnitView>().TName = Name;
            go.transform.localPosition = new Vector2(-700+(200*x), -150);
            x++;
        }
    }
    //CustomFunc::private
    //void
}
