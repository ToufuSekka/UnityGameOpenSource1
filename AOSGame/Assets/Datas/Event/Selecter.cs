using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selecter : MonoBehaviour{
    int CodeNo;
    string Name, description;
    List<Trigger> trig;
    List<Button> btn;
    List<Result> res;

    void Start() {
        creation();
    }

    void creation(/*string[] Data*/) {
        Button bts = GetComponent<Button>();
        bts.transform.Translate(new Vector3(0, 0, 0));
    }
}