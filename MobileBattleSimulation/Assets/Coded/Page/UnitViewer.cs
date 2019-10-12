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
        foreach (string[] ArrData in DATC.NormalUnitView()) {
            go = Instantiate(Resources.Load("UIData/NormalUnitView"), GameObject.Find("UnitViewr").transform) as GameObject;
            go.name = ArrData[1];
            go.GetComponent<UnitView>().UnitName = ArrData[0];
            go.GetComponent<UnitView>().FileName = ArrData[1];

            go.transform.localPosition = new Vector2(-700+(200*x), -150);
            x++;
        }
        Debug.Log("SpreadEnd");
    }
    //CustomFunc::private
    //void
}
