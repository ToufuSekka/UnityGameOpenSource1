using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour{
    public Object NoteType;
    public int ScoreLIne, ChordLine;
    public char NoteData;

    //ScoreLIne, ChordLine, Note, perfactTiming;
    public struct Note {
        public Object NoteType;
        public char NoteData;
        public int ScoreLIne, ChordLine;
        public float TicPerf;
    }
}