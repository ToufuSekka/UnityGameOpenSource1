using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript1 : MonoBehaviour{
    GameObject MSGWin, Subject, Content;
    GameObject[] Auto;

    string[] DATA= { "Fuck!","I want to Play Minecaft! get Out all!"};
    void Start(){
        Auto = new GameObject[3];
        Auto[0] = Resources.Load("UI/SysMSGView") as GameObject;
        Debug.Log("Called Full");

        for (int e = 1; e < 3; e++) {
            Auto[e] = Auto[0].transform.GetChild(e).GetChild(0).gameObject;
            Debug.Log("Called : " + Auto[e].name);
            Auto[e].GetComponent<Text>().text = DATA[e - 1];
            Debug.Log("Inserted");
        }
        Instantiate(Auto[0]);
    }
}