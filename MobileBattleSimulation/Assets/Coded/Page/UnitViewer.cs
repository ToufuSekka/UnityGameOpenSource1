﻿using UnityEngine;

public class UnitViewer : MonoBehaviour{

    DatCntl DATC = new DatCntl();
    GameObject go;
    int x = 1;
    //CallBack
    private void Start() {
        foreach (string[] ArrData in DATC.FilesView("NormalUnit",new string[] {"FileName","Name"})) {
            go = Instantiate(Resources.Load("UIData/NormalUnitView"), GameObject.Find("UnitViewr").transform) as GameObject;
            go.name = ArrData[1];
            go.GetComponent<UnitView>().FileName = ArrData[0];
            go.GetComponent<UnitView>().UnitName = ArrData[1];

            go.transform.localPosition = new Vector2(-700+(200*x), -150);
            x++;
        }
        Debug.Log("SpreadEnd");
    }
    //CustomFunc::private
    //void
}
