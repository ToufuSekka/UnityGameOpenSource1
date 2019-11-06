using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANICNTL{
    GameObject[] Obj;
    Animator[] Anim;

    //protected
    protected void SwitchTypeAnime(string Name, bool swiches) {
        Obj = new GameObject[2];
        Obj[0] = GameObject.Find("SlidingImage");
        Obj[1] = GameObject.Find("Slider");

        if (swiches) {
            Obj[0].GetComponent<Animator>().Play(Name+"Up");
            Obj[1].GetComponent<Animator>().Play("HideOn");
            Debug.Log("Active");
        }
        else {
            Obj[0].GetComponent<Animator>().Play(Name+"Down");
            Obj[1].GetComponent<Animator>().Play("HideOn");
            Debug.Log("DisActive");
        }
    }
}
