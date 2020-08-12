using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TCodes : MonoBehaviour{

    void Update(){

        if (Input.GetKey("w"))
            transform.Translate(Vector3.forward * 0.03f);
        if (Input.GetKey("s"))
            transform.Translate(Vector3.back * 0.03f);
        if (Input.GetKey("a"))
            transform.Translate(Vector3.left * 0.03f);
        if (Input.GetKey("d"))
            transform.Translate(Vector3.right * 0.03f);
    }
}
