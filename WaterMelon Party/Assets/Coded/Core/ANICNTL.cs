using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANICNTL{
    GameObject[] Obj;

    Animator[] Anim;

    //customFunc::public
    public void Slide(bool SwitchValue) {
        Obj = new GameObject[2];
        Obj[0] = GameObject.Find("SlidingImage");
        Obj[1] = GameObject.Find("Slider");

        if (SwitchValue) {
            Obj[0].GetComponent<Animator>().Play("SlideUp");
            Obj[1].GetComponent<Animator>().Play("HideOn");
            Debug.Log("Active");
        } else {
            Obj[0].GetComponent<Animator>().Play("SildeDown");
            Obj[1].GetComponent<Animator>().Play("HideOff");
            Debug.Log("DeActive");
        }
        Debug.Log("Sliding");
    }

    //customFunc::private
}
