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
    Hashtable table = new Hashtable();

    public List<object> NormalUnitView() {

        di = new DirectoryInfo(Application.dataPath + "/Resources/UnitData/NormalUnitData");
        foreach (FileInfo Fi in di.GetFiles("*.xml"))
        {
            string[] data = new string[2];
            data[0] = Fi.Name.Replace(".xml", null);
            TA = (TextAsset)Resources.Load("UnitData/NormalUnitData/" + data[0]);
            XmlDoc.LoadXml(TA.text);
            XmlNO = XmlDoc.SelectNodes("UnitData")[0];

            data[1] = XmlNO.SelectSingleNode("BaseData").Attributes["Name"].InnerText;
            Datas.Add(data);
        }
        Debug.Log(" Bring_Ends");
        return this.Datas;
    }

    protected List<object> Normal_Specific()
    {
        di = new DirectoryInfo(Application.dataPath + "/Resources/UnitData/NormalUnitData");
        foreach (FileInfo Fi in di.GetFiles("*.xml"))
        {
            string[] data = new string[2];
            data[0] = Fi.Name.Replace(".xml", null);
            TA = (TextAsset)Resources.Load("UnitData/NormalUnitData/" + data[0]);
            XmlDoc.LoadXml(TA.text);
            XmlNO = XmlDoc.SelectNodes("UnitData")[0];

            data[1] = XmlNO.SelectSingleNode("BaseData").Attributes["Name"].InnerText;
            Datas.Add(data);
        }
        Debug.Log(" Bring_Ends");
        return this.Datas;
    }
}