using System.Collections;
using System.Collections.Generic;
using System.IO;

using UnityEngine;

public class InGameParser : MonoBehaviour{
    TextAsset MastDat;
    GameObject Orig, Duply;//About Note
    GameObject ScreenVie, JdgLin;//Aboud Screen Object


    private void Start() {
        Orig = Resources.Load("Note") as GameObject;
        MastDat = Resources.Load("") as TextAsset;

        JdgLin = GameObject.Find("JudgeLine");//JudgeLine And Metromone
        ScreenVie = GameObject.Find("TotalScreen");//Controlling ImGame System. 

        DataRead(new StringReader(MastDat.text));
    }


    void DataRead(StringReader FulDatGet) {
        string LinDat = null;
        do {
            LinDat = FulDatGet.ReadLine();
            FstSort(LinDat);
        } while (LinDat != null);
    }

    void FstSort(string LineData) {
        if (LineData == null) return;
        char[] comcut = { ':', ';' };

        //DataType1
        if (LineData.StartsWith("#")) {
            string[] lines = LineData.Split(comcut);
            switch (lines[0]) {
                case "#SongName":
                    //Get The Text
                    break;
                case "#Tempo":
                    //float.Parse(lines[1]);
                    break;
            }
        }

        //DataType2
        if (LineData.StartsWith("@")) {
            string[] Score = LineData.Split(comcut);
            //NoteSort(Score);
        }
    }
}
