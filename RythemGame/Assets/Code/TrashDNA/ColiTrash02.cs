using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ColiTrash02 : MonoBehaviour{
    int testNumber = 0;


    public Queue<Notes> NotQ = new Queue<Notes>();
    Notes Not;

    float Tempos, X,Y, Stan, NVal;
    float x, y, r =50, Roll;
    float TickTime=0, RealTime=0, Ticks;
    TextAsset FullData;
    GameObject outOBJ, duply,vid;
    GameObject LineOBJ, Texts;

    void Start() {

        //Loader
        outOBJ = Resources.Load("Note") as GameObject;
        LineOBJ = GameObject.Find("Line");
        Texts = GameObject.Find("Text");
        vid = GameObject.Find("AThings");
        Reading();
    }

    void FixedUpdate() {
        SongCloak(Tempos);
        if (Time.frameCount % 60 == 0) System.GC.Collect();
    }

    //spreading Notes(Delete if complete under code "NotSpr" or another)
    private void Spraying(float ptV) {
        Roll = 720 / ptV;
        Debug.Log("Datafox : " + Roll);
        //360; A = b*h ->  A/h=b
        for (int j = 0; j < ptV; j++) {
            for (int h=1;h <9 ;h++) {
                x = (r*h) * Mathf.Cos(((Roll * j) - 180) * (Mathf.PI / -360));
                y = (r*h) * Mathf.Sin(((Roll * j) - 180) * (Mathf.PI / -360));
                duply = Instantiate(outOBJ, new Vector2(x, y), Quaternion.identity, GameObject.Find("Image").transform);
            }
            Debug.Log("Loc : "+ Roll * j);
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
                    Debug.Log(lines[1]);
                    break;
                case "#Composer":
                    Debug.Log(lines[1]);
                    break;
                case "#Tempo":
                    Debug.Log(lines[1]);
                    Tempos = int.Parse(lines[1]);
                    break;
            }
        }

        //DataType2
        if (ALineData.StartsWith("@")) {
            string[] Score = ALineData.Split(comcut);
            Debug.Log(ALineData);
            NotSpr(Score);
        }
    }

    private void NotSpr(string[] SocreLine) {
        // 0=ScoreLine, 1=ChordLine, 2=Note
        float OriginOne = 1, LenDiv;

        char[] ptns = SocreLine[2].ToCharArray();
        LenDiv = OriginOne / ptns.Length;

        float TolCir = 720 / ptns.Length;
        float MinRad = 50;

        for (int St = 0; St < ptns.Length; St++) {
            LenDiv = OriginOne / ptns.Length;
            outOBJ.GetComponent<Notes>().ScoreLIne = int.Parse(SocreLine[0].Replace("@", null));
            outOBJ.GetComponent<Notes>().ChordLine = int.Parse(SocreLine[1].Replace("@", null));
            float NVal = int.Parse(SocreLine[1].Replace("@", null));

            outOBJ.GetComponent<Notes>().TicPerf = outOBJ.GetComponent<Notes>().ScoreLIne + (LenDiv * St);
            outOBJ.GetComponent<Notes>().NoteData = ptns[St];

            x = (MinRad * NVal) * Mathf.Cos(((TolCir * St) - 180) * (Mathf.PI / -360));
            y = (MinRad * NVal) * Mathf.Sin(((TolCir * St) - 180) * (Mathf.PI / -360));
            duply = Instantiate(outOBJ, new Vector2(x, y), Quaternion.identity, GameObject.Find("Image").transform);
            testNumber++;

            duply.name = testNumber.ToString();
            duply.SetActive(false);
        }
    }
    private void SongCloak(float BPM) {
        GameObject Text2 = GameObject.Find("Text2");

        Ticks = Time.deltaTime * (BPM / 60) / 4;
        TickTime += Ticks;
        RealTime += Time.deltaTime;

        LineOBJ.transform.Rotate(new Vector3(0, 0, -Ticks * 360));

        Text2.GetComponent<Text>().text =
            "Tick : " + TickTime.ToString("F2") +
            ", Real :" + RealTime.ToString("F2") +
            ", BPM :" + BPM;
    }
}
