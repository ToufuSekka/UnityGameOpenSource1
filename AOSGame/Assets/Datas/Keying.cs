using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keying : MonoBehaviour{
    void Update() {
        if (Input.anyKeyDown) {
            if (Input.GetKey(KeyCode.Space))
                StartCoroutine("Space");
            else if (Input.GetKey(KeyCode.Tab))
                StartCoroutine("Tab");
            else {
                char[] cArr = Input.inputString.ToCharArray();
                foreach (char c in cArr )
                    StartCoroutine(c.ToString());
            }
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

    IEnumerator w() {
        Debug.Log("Walking");
        yield return null;
    }

    IEnumerator W() {
        Debug.Log("Running");
        yield return null;
    }
    IEnumerator s() {
        Debug.Log("Back");
        yield return null;
    }
    IEnumerator a() {
        Debug.Log("Left");
        yield return null;
    }
    IEnumerator d() {
        Debug.Log("Right");
        yield return null;
    }

    IEnumerator Space() {
        Debug.Log("Jumping");
        yield return null;
    }

    IEnumerator Tab() {
        Debug.Log("Tabbing");
        yield return null;
    }
}
