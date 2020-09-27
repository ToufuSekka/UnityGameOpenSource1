using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ColiTrash02 : MonoBehaviour{
    int testNumber = 0;
    int je = 0;
    float X, Y, Stan, NVal;
    float Tempo;
    Notes Not;

    TextAsset FullData;
    GameObject outOBJ, duply,vid;
    GameObject LineOBJ, Text;

    public static List<GameObject[]> NotePaper = new List<GameObject[]>();

    void Start() {
        outOBJ = Resources.Load("Note") as GameObject;
        LineOBJ = GameObject.Find("Line");
        Text = GameObject.Find("Text2");
        vid = GameObject.Find("AThings");
        LineOBJ.AddComponent<ComCloak>();
        Reading();
    }

    void FixedUpdate() {
        if (Time.frameCount % 60 == 0) System.GC.Collect();

        LineOBJ.GetComponent<ComCloak>().SongCloak(Tempo);

        Text.GetComponent<Text>().text =
            "Tick : " + ComCloak.MetroClok +
            ", BPM :" + Tempo;

        for (int p = 0; p < NotePaper.Count; p++) {
            for (int q = 0; q < NotePaper[p].Length; q++) {
                if (NotePaper[p][q].Equals(null)) {
                    continue;
                } else if (NotePaper[p][q].GetComponent<Notes>().TicPerf - 0.5 < ComCloak.MetroClok) {
                    NotePaper[p][q].SetActive(true);
                }
            }
        }
    }

    //TestSorter
    private void Reading() {
        FullData = Resources.Load("SongData/Test") as TextAsset;
        StringReader strReader = new StringReader(FullData.text);
        string LocalLIne = "";

        do {
            LocalLIne = strReader.ReadLine();
            Sorter(LocalLIne);
        } while (LocalLIne != null);
    }

    private void Sorter(string ALineData) {
        if (ALineData == null) return;
        char[] comcut = { ':', ';' };

        //DataType1
        if (ALineData.StartsWith("#")) {
            string[] lines = ALineData.Split(comcut);
            switch (lines[0]) {
                case "#SongName":
                    break;
                case "#Composer":
                    break;
                case "#Tempo":
                    Tempo = int.Parse(lines[1]);
                    break;
            }
        }

        //DataType2
        if (ALineData.StartsWith("@")) {
            string[] Score = ALineData.Split(comcut);
            NoteSort(Score);
        }
    }

    private void NoteSort(string[] ScoLine) {
        // 0=ScoreLine, 1=ChordLine, 2=Note
        float ScoNo = float.Parse(ScoLine[0].Replace("@", null));
        float ChoNo = float.Parse(ScoLine[1]);
        char[] NType = ScoLine[2].ToCharArray();

        GameObject[] Garr = new GameObject[NType.Length];
        float OriginOne = 1, LenDiv;
        float TolCir = 720 / NType.Length;
        float MinRad = 100, DefRad = 40;

        for (int St = 0 ;St < NType.Length ;St++ ){
            LenDiv = OriginOne / NType.Length;
            outOBJ.GetComponent<Notes>().ScoreLIne = ScoNo;
            outOBJ.GetComponent<Notes>().ChordLine = ChoNo;
            outOBJ.GetComponent<Notes>().TicPerf = ScoNo + (LenDiv * St);
            outOBJ.GetComponent<Notes>().NoteData = NType[St];

            X = (MinRad + (DefRad * ChoNo)) * Mathf.Cos(((TolCir * St) - 180) * (Mathf.PI / -360));
            Y = (MinRad + (DefRad * ChoNo)) * Mathf.Sin(((TolCir * St) - 180) * (Mathf.PI / -360));
            duply = Instantiate(outOBJ, new Vector2(X, Y), Quaternion.identity, GameObject.Find("Image").transform);
            duply.name = je.ToString();
            duply.SetActive(false);
            Garr[St] = duply;
            je++;
        }
        NotePaper.Add(Garr);
    }
}
