using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPather{
    static Stack<string> SceneSaver = new Stack<string>();
    public static DataPather Pather;

    private void Start() {
        Pather = this;
    }

    public void ScenePush(string SceneName){
        SceneSaver.Push(SceneName);
        Debug.Log(SceneSaver.Peek());
    }

    public string ScenePop() {
        if (SceneSaver.Count ==0)
            return "Null";

        string popping=SceneSaver.Pop();
        Debug.Log(popping);

        return popping;
    }

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