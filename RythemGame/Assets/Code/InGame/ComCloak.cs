using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComCloak : MonoBehaviour{

    private float Tick;
    public static float MetroClok { get; private set; }
    private float RealClok;
    private float BPM;
    GameObject ClokLine;

    private void Start() {
        ClokLine = GameObject.Find("Line");
        MetroClok = 0f;
    }

    public void SongCloak(float BPM) {
        Tick = Time.deltaTime * (BPM / 60) / 4;
        MetroClok += Tick;
        RealClok += Time.deltaTime;

        ClokLine.transform.Rotate(new Vector3(0, 0, -Tick * 360));
    }
}
