using UnityEngine;

using System.Xml;
using System;

public class NormalUnitPage : MonoBehaviour{
    GameObject Unit, go, InnerView;
    TextAsset Ta;
    XmlDocument XmlDoc= new XmlDocument();
    XmlNodeList XmlNL = null;

    int x=-700,y=250;
    string KeyName="";

    void Start() {
        runner();
    }

    void runner() {
        Unit = Resources.Load("UnitData/Normal/Unit") as GameObject;
        InnerView = GameObject.Find("InnerViwe");
        Ta = (TextAsset)Resources.Load("UnitData/Normal/NormalUnit");
        XmlDoc.LoadXml(Ta.text);
        XmlNL = XmlDoc.SelectNodes("UnitData/NomalUnit");

        foreach (XmlNode XmlNo in XmlNL) {
            for (int r =0; r <16;r++) {
                KeyName = Enum.GetName(typeof(DataSector), r);
                if (!Unit.GetComponent<NormalUnit>().UnitDatas.ContainsKey(KeyName)) {
                    Unit.GetComponent<NormalUnit>().UnitDatas.Add(KeyName, XmlNo.SelectSingleNode(KeyName).InnerText);
                } else {
                    Unit.GetComponent<NormalUnit>().UnitDatas[KeyName] =XmlNo.SelectSingleNode(KeyName).InnerText;
                }
            }

            x += 150;
            if (x > 500) {
                y -= 150;
                x = -700 + 150;
            }
            go = Instantiate(Unit, InnerView.transform);
            go.transform.localPosition = new Vector2(x, y);
            go.name = Unit.GetComponent<NormalUnit>().UnitDatas["Name"].ToString();
        }
        Debug.Log("Total Unit ListComplete");
    }
}
