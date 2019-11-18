using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Squad : MonoBehaviour{
    GameObject[] Units;
    Image img;
    Text txt;

    DatCntl DAT= new DatCntl();

    void Start(){
        Units = new GameObject[8];
        //DAT.AXmlFileview("Squads", "Squad_"+ selected(1));
        for (int a =0;a < Units.Length ;a++) {
            Units[a] = GameObject.Find("");
        }
    }

    string selected(int number){
        string selectNum= "1";
        return selectNum;
    }
}
