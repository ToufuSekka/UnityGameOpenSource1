using System.Collections.Generic;
using System.Collections;
using System;
using UnityEngine;
using System.IO;
using System.Xml;


public class DatCntl{
    TextAsset TA;

    DirectoryInfo di;
    XmlDocument XmlDoc = new XmlDocument();
    XmlNode XmlNO = null;
    List<object> Datas = new List<object>();

    readonly string UnChangablePath= "UnitData/NormalUnitData";

    public List<object> UnitView(string Type) {

        di = new DirectoryInfo(Application.dataPath + "/Resources/UnitData/" + Type);
        foreach (FileInfo Fi in di.GetFiles("*.xml")){
            string[] data = new string[2];
            data[0] = Fi.Name.Replace(".xml", null);
            TA = (TextAsset)Resources.Load(UnChangablePath + "/" + data[0]);
            XmlDoc.LoadXml(TA.text);
            XmlNO = XmlDoc.SelectNodes("NormalUnit")[0];

            data[1] = XmlNO.SelectSingleNode("DataInput").SelectSingleNode("Name").InnerText;
            Datas.Add(data);
        }
        Debug.Log("Bring_Ends");
        return this.Datas;
    }

    public List<object> NormalDetail(string FileName){
        TA = (TextAsset)Resources.Load(UnChangablePath + "/" + FileName);
        XmlDoc.LoadXml(TA.text);
        XmlNO = XmlDoc.SelectNodes("NormalUnit")[0];

        for (int r =0x00;r < 0x0e ; r++) {
            Datas.Add(XmlNO.SelectSingleNode("DataInput").SelectSingleNode(Enum.GetName(typeof(ParseSet), r)).InnerText);
        }
        return this.Datas;
    }

    protected List<object> Test(string FileName){
        TA = (TextAsset)Resources.Load(UnChangablePath + "/" + FileName);
        XmlDoc.LoadXml(TA.text);
        XmlNO = XmlDoc.SelectNodes("NormalUnit")[0];

        for (int r = 0x00; r < 0x0e; r++)
        {
            Datas.Add(XmlNO.SelectSingleNode("DataInput").SelectSingleNode(Enum.GetName(typeof(ParseSet), r)).InnerText);
        }
        return this.Datas;
    }
}