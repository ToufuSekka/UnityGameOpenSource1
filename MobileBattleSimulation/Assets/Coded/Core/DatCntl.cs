using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;


public class DatCntl : MonoBehaviour{
    TextAsset TA;

    DirectoryInfo di;
    XmlDocument XmlDoc = new XmlDocument();
    XmlNode XmlNO = null;
    List<object> Datas = new List<object>();

    public List<object> Viewing(string PageType) {
        Object go, go2;

        switch (PageType) {
            default:
                di = new DirectoryInfo(Application.dataPath + "/Resources/UnitData/NormalUnitData");
                foreach (FileInfo Fi in di.GetFiles("*.xml")) {
                    TA = (TextAsset)Resources.Load("UnitData/NormalUnitData/" + Fi.Name.Replace(".xml", null));
                    XmlDoc.LoadXml(TA.text);
                    XmlNO = XmlDoc.SelectNodes("UnitData")[0];
                    Datas.Add(XmlNO.SelectSingleNode("BaseData").Attributes["Name"].InnerText);
                }
                break;
        }
        Debug.Log(" Bring_Ends");
        return this.Datas;
    }

    public List<int> UnitViews(string PageType) {
        List<int> returner = new List<int>();
        switch (PageType) {
            default:
                di = new DirectoryInfo(Application.dataPath + "/Resources/UnitData/NormalUnitData");
                foreach (FileInfo Fi in di.GetFiles("*.xml")) {
                    TA = (TextAsset)Resources.Load("UnitData/NormalUnitData/" + Fi.Name.Replace(".xml", null));
                    XmlDoc.LoadXml(TA.text);
                    XmlNO = XmlDoc.SelectNodes("UnitData")[0];
                    Debug.Log(XmlNO.SelectSingleNode("BaseData").Attributes["Name"].InnerText);
                }
                Debug.Log(" Bring_Ends");
                break;
        }
        return returner;
    }
}
