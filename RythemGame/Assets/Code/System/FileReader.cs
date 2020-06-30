using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileReader : MonoBehaviour{
    TextAsset Ta;
    string TestEXT, TestNM,TextData, wool;

    string Data;

    private void Awake() {
        FileTyper(null, "The Test", (FileTypes)1);
    }

    private void Start() {
        Debug.Log(TestEXT);
        Debug.Log(TestNM);
        Debug.Log(wool);
    }

    //this types are many... ;;
    private void FileTyper(string FileDIR, string FileName, FileTypes EXTType) {
        string UnchnagedPath = "Assets/Resources/";

        if (FileDIR == null) {
            wool = File.ReadAllText(UnchnagedPath+FileName+"."+EXTType);
            TestEXT = System.IO.Path.GetExtension(UnchnagedPath+FileName+ "." + EXTType);
            TestNM = Path.GetFileName(UnchnagedPath+FileName+ "." + EXTType);
        } else {
            //
        }
    }
}