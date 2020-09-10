using System.Collections;
using System.Collections.Generic;
using System.IO;

using UnityEngine;

public class InGameParser : MonoBehaviour{
    TextAsset TA;
    StringReader strReader;
    string LineDatas= "";

    void Start() {
        BringAndRead();
    }

    void BringAndRead() {
        TA = Resources.Load("SongData/Test") as TextAsset;
        strReader = new StringReader(TA.text);

        do {
            LineDatas = strReader.ReadLine();
            Parse(LineDatas);
        } while (LineDatas !=null);
        
    }

    void Parse(string LineData) {
        if (LineDatas == null) return;
        char[] cutter = { ':', ';' };

        if (LineData.StartsWith("#")) {
            string[] lines= LineData.Split(cutter);
            switch (lines[0]) {
                case "#SongName":
                    Debug.Log(lines[1]);
                    break;
                case "#Composer":
                    Debug.Log(lines[1]);
                    break;
                case "#Tempo":
                    Debug.Log(lines[1]);
                    break;
            }
        }

        if (LineData.StartsWith("@")) {
            string[] Datas = LineData.Split(cutter);
        }
    }
}
