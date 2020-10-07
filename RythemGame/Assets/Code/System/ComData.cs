using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComData : MonoBehaviour{

    public static string MossWriter="";

    public void MossReader() {

    }

    //JSON
    public void JsonRead() {

    }

    public void JsonWrite() {

    }

    //prefabs
    public void PrefabsRead() {

    }

    public void PrefabsWrite(string Data) {
        PlayerPrefs.SetString("UserID",Data);
    }
}
