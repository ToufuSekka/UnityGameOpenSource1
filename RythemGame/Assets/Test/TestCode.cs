using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestCode : MonoBehaviour{
    Timer timer = new Timer(60);
    Text texts, texts2;

    float x = 0, y = 0, r = 350, Angle =- 90.0f, ts = 0;
    int N=192;
    Object ob, outs;

    int k= 0;
    private void Start() {
        texts = GameObject.Find("Timerstempo").GetComponent<Text>();
        texts2 = GameObject.Find("functions").GetComponent<Text>();
        ob = Resources.Load("Image");
    }

    private void Update() {
        timer.StartTimer();
        ts = timer.getTimeData(3)%192;
        x = Mathf.Cos(Mathf.Deg2Rad * Angle) * r;
        y = Mathf.Sin(Mathf.Deg2Rad * Angle) * r;
        outs = Instantiate(ob, new Vector2(x, y), Quaternion.identity, GameObject.Find("Canvas").transform);
       
        texts.text = "Now : " +timer.getClock()+ ", "+
            "Now Tempo : " + timer.getTempo() +", ";
        texts2.text = x.ToString("N3") + " : " + y.ToString("N3");
    }
}