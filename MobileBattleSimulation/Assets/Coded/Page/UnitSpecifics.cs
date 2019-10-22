using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnitSpecifics : MonoBehaviour{
    DatCntl DC = new DatCntl();
    Text text;

    void Start(){

        foreach (var data in DC.NormalDetail(DataPather.FileData)) {
            Debug.Log(data);
        }
        Debug.Log("Called " + DataPather.FileData);
    }
}
