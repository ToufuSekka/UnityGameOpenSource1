using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPather{
    static Stack<string> SceneSaver = new Stack<string>();
    static string ChapterSaver;

    public static List<GameObject> realData = new List<GameObject>();
    public static DataPather Pather;

    //callBack
    private void Start() {
        Pather = this;
    }

    //Custom Func
    //void
    public void ScenePush(string SceneName) {
        SceneSaver.Push(SceneName);
        Debug.Log(SceneSaver.Peek());
    }

    public void ChapterBucket(string ChapterName) {
        ChapterSaver = ChapterName;
    }

    //string
    public string ScenePop() {
        if (SceneSaver.Count == 0)
            return "Null";

        string popping = SceneSaver.Pop();
        return popping;
    }

    public string CahpterNamer() {
        return ChapterSaver;
    }

    //int
    public int SaverCounter(string SaverName) {
        int counter = 0;
        if (SaverName == null)
            return 0;

        switch (SaverName) {
            case "Scene":
                counter = SceneSaver.Count;
                break;
        }
        return counter;
    }
}
