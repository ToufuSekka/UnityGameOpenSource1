using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColiTrash01 : MonoBehaviour{

    GameObject obj,obj2;

    private void Timedivid() {
        float timer = 1, tri =8, diviv;

        //divivi is ArrayLength
        diviv = timer / tri;
        for (int j =0;j<tri ;j++) {
            Debug.Log(diviv*j);
        }
        
    }
}
