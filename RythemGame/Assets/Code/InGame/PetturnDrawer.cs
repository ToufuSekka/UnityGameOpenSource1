using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetturnDrawer : MonoBehaviour{

    //this draw and view parsed data
    Timer timer = new Timer(300);
    readonly float RADIUS = 350;

    float x = 0, y = 0, Angle = -90.0f, ts = 0;
    int N = 16;
    Object ob, outs;

    int k = 0;
    private void Start() {
        ob = Resources.Load("Image");
    }
    private void Update() {
        timer.StartTimer();
        //ts = timer.getSmallTime()/12;
        x = Mathf.Cos(Mathf.Deg2Rad * Angle) * RADIUS;
        y = Mathf.Sin(Mathf.Deg2Rad * Angle) * RADIUS;
        if (ts > 7) {
            Angle += 360.0f / (N);
            outs = Instantiate(ob, new Vector2(x, y), Quaternion.identity, GameObject.Find("Canvas").transform);
        }
    }
}
