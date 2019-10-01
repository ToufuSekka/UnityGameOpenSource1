using System.Collections.Generic;
using System.IO;
using System.Xml;

using UnityEngine;
using UnityEngine.UI;

public class ChapPage : MonoBehaviour{

    DirectoryInfo FileFinder;
    float x, y;

    //callback
    void Start() {
        FileFinder = new DirectoryInfo(Application.dataPath + "/Resources/Memory/Chapter");
        foreach (FileInfo finder in FileFinder.GetFiles("*.xml")){
            Debug.Log(finder.Name + " Logged");
        }
    }

    //customFunc
}
