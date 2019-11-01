using System;

using UnityEngine;
using UnityEngine.UI;

public class UnitSpecifics : MonoBehaviour {
    int r =0;
    DatCntl DC = new DatCntl();
    Text[] text =new Text[15];
    Text test;
    void Start(){
        
        foreach (var data in DC.AXmlFileview("NormalUnit", DataPather.FileData)) {
            string Finder = Enum.GetName(typeof(ParseSet), r) + "_Data";
            text[r] = GameObject.Find(Finder).GetComponent<Text>();
            switch (r) {
                case 1:
                    text[r].text = Enum.GetName(typeof(UnitType),Int32.Parse(data.ToString()));
                    break;
                case 2:
                    text[r].text = Enum.GetName(typeof(ArmorType), Int32.Parse(data.ToString()));
                    break;
                case 3:
                    text[r].text = Enum.GetName(typeof(WeaponType), Int32.Parse(data.ToString()));
                    break;
                default:
                    text[r].text = data.ToString();
                    break;
            }
            r++;
        }
        Debug.Log("Called " + DataPather.FileData);
    }
}