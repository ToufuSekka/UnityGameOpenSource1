using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour{
    public Object NoteType;
    public int ScoreLIne, ChordLine;
    public char NoteData;

    //ScoreLIne, ChordLine, Note;
    public struct Note {
        public Object NoteType;
        public int ScoreLIne, ChordLine;
        public char NoteData;
    }
}