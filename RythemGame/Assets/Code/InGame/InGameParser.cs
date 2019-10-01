using System.Collections;
using System.Collections.Generic;
using System.IO;

using UnityEngine;

public class InGameParser{
    TextAsset TA;
    StreamReader strReader;
    string LineDatas= "";

    void BringAndRead() {
        TA =(TextAsset) Resources.Load("SongData");
        strReader = new StreamReader(TA.text);

        do {
            LineDatas = strReader.ReadLine();
            Parse(LineDatas);
            Debug.Log(LineDatas);
        } while (LineDatas==null);
    }

    void Parse(string LineData) {
        if (LineDatas == null) return;

    }

    string[] Divider(string Datas) {
        char[] div = {';'};
        string[] divdedDatas= { };
        divdedDatas = Datas.Split(div);

        return divdedDatas;
    }
}
