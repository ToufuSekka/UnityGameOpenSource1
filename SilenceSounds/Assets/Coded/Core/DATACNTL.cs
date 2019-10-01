using System.Collections.Generic;
using System.Collections;
using System;
using System.IO;
using System.Xml;

using UnityEngine;
enum XmlPre {
    //닥치고 8진수로 표기 할것.
    Name = 00, Preimg = 01, Preview = 02,
    Type = 010, locked = 011, Description = 012,
}

public class DATACNTL : MonoBehaviour{
    Processor Proc = new Processor();

    DirectoryInfo FileFinder;
    XmlDocument XmlDoc = new XmlDocument();
    XmlNode XmlNos;

    TextAsset TA;
    GameObject[] Objects;

    ArrayList FinalBwol;

    //CustomFunc::Public
    //void
    public void ChapSpray(string SprayType) {
        FileFinder = new DirectoryInfo(Application.dataPath + "/Resources/Memory/"+ SprayType);
        foreach (FileInfo finder in FileFinder.GetFiles("*.xml")) {
            ChapDataDiv(ChapterLists(finder.Name),finder.Name.Replace(".xml",""));
        }
    }

    public void DataOutputter(string[] Datas) {
        switch (Datas[0]) {
            case "sound":
                Proc.Audior(Datas[2]);//create more
                break;
            case "logger":
                Proc.Logger(Datas[2]);
                break;
            case "image":
                Proc.Imager(Datas[2]);//create more
                break;
        }
    }

    //string[]
    public string[] DataSorter(string FileName, int number) {
        string[] Datapool = new string[3];
        XmlLoader(FileName, number, "Datas/Line");

        // 0=DataParsType,1= BreakPoint,2 = Datas
        try {
            for (int a = 0; a < 2; a++) {
                Datapool[a] = XmlNos.Attributes[Enum.GetName(typeof(XmlPre), a + 010)].InnerText;
            }
            Datapool[2] = XmlNos.SelectNodes(Enum.GetName(typeof(XmlPre), 012))[0].InnerText;
        } catch (NullReferenceException NRE) {
            Datapool[0] = "logger";
            Datapool[1] = "Auto";
            Datapool[2] = "NullData;NullData";
        }
        return Datapool;
    }

    //private
    //void
    private void ChapDataDiv(ArrayList Data, string ChapName) {
        Objects = new GameObject[3];
        Objects[0] = Resources.Load("UI/Chapter") as GameObject;
        Objects[1] = GameObject.Find("DataList");

        Objects[0].GetComponent<ChapterLoader>().ChapName =(string) Data[0];
        //Objects[0].GetComponent<ChapterLoader>().Sportlite = Data[2];
        Objects[0].GetComponent<ChapterLoader>().Description =(string) Data[2];

        Objects[2] = Instantiate(Objects[0], Objects[1].transform);
        Objects[2].name = ChapName;
    }

    private void XmlLoader(string FileName, int StartArrNum, string FrontNote) {
        TA = (TextAsset)Resources.Load("Memory/Chapter/" + FileName);
        XmlDoc.LoadXml(TA.text);
        XmlNos = XmlDoc.SelectNodes(FrontNote)[StartArrNum];
    }

    //ArrayList 
    private ArrayList ChapterLists(string FileName) {
        if (FileName == null || FileName.Equals("")) throw new NullReferenceException("데이터 오류");
        this.FinalBwol = new ArrayList();
        XmlLoader(FileName.Replace(".xml", ""), 0, "Datas");

        foreach (XmlNode XmlNo in XmlNos.SelectNodes("Chapter")) {
            for (int r = 00; r < 03; r++) {
                FinalBwol.Add(XmlNo.Attributes[Enum.GetName(typeof(XmlPre), r)].InnerText);
            }
        }
        return FinalBwol;
    }
}
