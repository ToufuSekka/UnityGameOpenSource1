using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColiTrash01 : MonoBehaviour{

    GameObject obj,obj2;

    float vT = 0, tick;

    private void Start(){

        obj = GameObject.Find("Line");
        obj2 = GameObject.Find("Text");
    }

    private void FixedUpdate() {
        tick = Time.deltaTime * (300 / 60) / 4;
        vT += Time.deltaTime;

        obj2.GetComponent<Text>().text = "Tick is : " + tick.ToString() + ", Time is :" + vT.ToString();
        obj.transform.Rotate(new Vector3(0, 0, -tick * 360));
    }
}
