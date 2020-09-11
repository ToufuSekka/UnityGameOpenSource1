using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ColiTrash02 : MonoBehaviour{

    float x, y, r =300, Roll;
    float TickTime=0, RealTime=0, Ticks;
    Notes.Note notdat;

    TextAsset FullData;
    GameObject outOBJ, duply,vid;
    GameObject LineOBJ, Texts;


    void Start() {

        //Loader
        outOBJ = Resources.Load("Note") as GameObject;
        LineOBJ = GameObject.Find("Line");
        Texts = GameObject.Find("Text");
        vid = GameObject.Find("AThings");

        Rolled(PtnSpreyer());
        Reading();
    }

    void FixedUpdate() {
        SongCloak(Tempos);
    }


    //BPMAnd RolledTest
    private int PtnSpreyer() {
        string aLIne="qdagdfsdfasdqwdafggfdgaafd";
        char[] ptns = aLIne.ToCharArray();
        int h = ptns.Length;
        return h;
    }

    private void Ticker(int BPM) {
        Ticks =Time.deltaTime * (BPM / 60) / 4;
        TickTime +=Ticks;
        RealTime += Time.deltaTime;

        LineOBJ.transform.Rotate(new Vector3(0, 0, -Ticks * 360));

        Texts.GetComponent<Text>().text =
            "TickTime : " + TickTime.ToString() +
            ", RealTime is :" + RealTime.ToString();
    }

    private void Rolled(int ptV) {
        Roll = 720 / ptV;
        Debug.Log("NoteValues : " + ptV);

        //360; A = b*h ->  A/h=b
        for (int j = 0; j < ptV; j++) {
            x = r * Mathf.Cos(((Roll * j) - 180) * (Mathf.PI / -360));
            y = r * Mathf.Sin(((Roll * j) - 180) * (Mathf.PI / -360));
            duply = Instantiate(outOBJ, new Vector2(x, y), Quaternion.identity, GameObject.Find("AThings").transform);
        }
    }

    //TestSorter
    int Tempos;
    
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
            NotSpr(Score);
            Debug.Log("Score: "+Score[0]+ ", Line : "+Score[1]+ ", Notes :"+Score[2]);
        }
    }

    private int NotSpr(string[] SocreLine) {
        // 0=ScoreLine, 1=ChordLine, 2=Note
        char[] ptns = SocreLine[2].ToCharArray();
        notdat.ScoreLIne =int.Parse(SocreLine[0]);
        notdat.ChordLine = int.Parse(SocreLine[1]);
        notdat.NoteData = ptns[0];

        int h = ptns.Length;
        return h;
    }

    private void SongCloak(int BPM) {
        GameObject Text2 = GameObject.Find("Text2");

        Ticks = Time.deltaTime * (BPM / 60) / 4;
        TickTime += Ticks;
        RealTime += Time.deltaTime;
        //LineOBJ.transform.Rotate(new Vector3(0, 0, -Ticks * 360));

        Text2.GetComponent<Text>().text =
            "TickTime : " + TickTime +
            ", RealTime :" + RealTime +
            ", Now BPM :" + BPM;
    }
}
