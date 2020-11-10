using System.Collections.Generic;
using System.Collections;
using System;
using UnityEngine;
using System.IO;
using System.Xml;

public class DatCntl{
    public static Stack<string> ScreenSaver = new Stack<string>();

    TextAsset TA;

    DirectoryInfo di;
    XmlDocument XmlDoc = new XmlDocument();
    XmlNode XmlNO = null;
    List<object> Datas = new List<object>();

    string BigPath;
    
    public List<object> FilesView(string Type, string[] dataName) {
        BigPath = PathSwichter(Type);

        di = new DirectoryInfo(Application.dataPath + "/Resources/"+ BigPath + "/" + Type);
        foreach (FileInfo Fi in di.GetFiles("*.xml")){
            string[] data = new string[dataName.Length];
            data[0] = Fi.Name.Replace(".xml", null);
            TA = (TextAsset)Resources.Load(BigPath + "/"+ Type + "/" + data[0]);
            XmlDoc.LoadXml(TA.text);
            XmlNO = XmlDoc.SelectNodes(Type)[0];
            for (int r= 1;r< dataName.Length ;r++) 
                data[r] = XmlNO.SelectSingleNode("DataInput").SelectSingleNode(dataName[r]).InnerText;

            Datas.Add(data);
        }
        Debug.Log("Bring_Ends");
        return this.Datas;
    }

    public List<object> AXmlFileview(string Type,string FileName){
        BigPath = PathSwichter(Type);

        TA = (TextAsset)Resources.Load(BigPath + "/" + Type + "/"+ FileName);
        XmlDoc.LoadXml(TA.text);
        XmlNO = XmlDoc.SelectNodes(Type)[0];
    
        for (int r =0x00;r < 0x0e ; r++)
            Datas.Add(XmlNO.SelectSingleNode("DataInput").SelectSingleNode(Enum.GetName(typeof(ParseSet), r)).InnerText);
        return this.Datas;
    }

    private string PathSwichter(string Type) {
        string returner="";
        switch (Type)
        {
            case "NormalUnit":
            case "Hero":
                returner = "UnitData";
                break;
            case "Squad":
                returner = "UserData";
                break;
        }
        return returner;
    }
}