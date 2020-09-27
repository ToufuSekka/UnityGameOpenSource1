using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour{
    public float ScoreLIne=0;
    public float ChordLine=0;
    public float TicPerf=0;
    public char NoteData='e';

    private void FixedUpdate() {
        if (TicPerf + 0.125 < ComCloak.MetroClok) {
            Destroy(gameObject);
        }
    }
}