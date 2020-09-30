using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour{
    public float ScoreLIne=0;
    public float ChordLine=0;
    public float TicPerf=0;
    public char NoteData='e';

    Animation Anim;

    private void FixedUpdate() {
        //Init Ahnd call
        if (TicPerf + 0.125 < ComCloak.MetroClok) {
            Destroy(gameObject);
        }

        //touching
    }

    //Score And Animation
    IEnumerator Perf() {

        yield return null;
    }

    IEnumerator Coll() {
        yield return null;
    }

    IEnumerator Miss() {
        yield return null;
    }
}