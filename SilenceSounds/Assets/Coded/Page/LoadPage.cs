using System.Collections;
using System.Collections.Generic;
using System.Xml;

using UnityEngine;

public class LoadPage : MonoBehaviour{

    XmlDocument XmlDoc = new XmlDocument();
    XmlElement XmlEle;
    XmlNodeList XmlNL;

    TextAsset TA;
    GameObject Loader= null, Instance;

    float x=-500, y=50;
    //callback
    void Start(){
        for (int i =0;i<6 ;i++) {
            Loader = Resources.Load("UI/Load") as GameObject;
            Instance = Instantiate(Loader, GameObject.Find("Loader").transform);
            Instance.name = "Load"+i;
            //ReadAndSprd(Instance);

            if (x > 500) {
                x = -500;
                y -= 300;
            }
            Instance.transform.position = new Vector2(x,y);
            x +=500;
        }
    }

    //customFunc::public

    //customFunc::private
    void ReadAndSprd(GameObject Load) {
        TA = (TextAsset)Resources.Load("Memory/SaveMemo");
        XmlDoc.LoadXml(TA.text);
        XmlNL = XmlDoc.SelectNodes("");

        foreach (XmlNode node in XmlNL) {
            Load.GetComponent<ScriptLoader>().Page=int.Parse(node.SelectSingleNode("").InnerText);
        }
    }
}