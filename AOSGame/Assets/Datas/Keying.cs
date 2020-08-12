using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keying : MonoBehaviour{
    string[] KeySet= {"wsad" };

    void Update() {
        if (Input.anyKeyDown) {
            Debug.Log(Input.inputString);
            StartCoroutine(Input.inputString.ToUpper());
        }
    }

    //wasd <- walk, space <- Jump, CTNL+w <- Run, Shift <- Shrink,

    //Hand Using
    //Major Hand Mouse0 <- Normal, Q <- Special
    // minor Hand Mouse2 <- Normal, E <- Special

    //Z <- User Selection
    //X <- Trees&Mission
    //C <- Tagging
    //V <- Aliencing
    //B <- Invnetory
    //1-9 keys <- Quick Slot

    IEnumerator W() {
        yield return null;
    }
    IEnumerator S() {
        yield return null;
    }
    IEnumerator A() {
        yield return null;
    }
    IEnumerator D() {
        yield return null;
    }
    IEnumerator Shringking() {
        yield return null;
    }

    IEnumerator SPACE() {
        Debug.Log("Space");
        yield return null;
    }
}
