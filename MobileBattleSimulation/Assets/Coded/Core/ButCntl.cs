using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButCntl : MonoBehaviour{
    Button btn;

    //Callback

    //customFunc::public

    //void
    public void Gate(string SceneName) {
        DataPather.SceneSaver.Push(SceneManager.GetActiveScene().name);
        if(SceneName == null || SceneName.Equals(""))
            SceneManager.LoadScene(BasicBtnName());
        else
            SceneManager.LoadScene(SceneName);
    }

    public void BAECntl() {
        if (DataPather.SceneSaver.Count.Equals(0))
            Exit();
        else
            BackDoor();
    }

    public void BackDoor() {
        SceneManager.LoadScene(DataPather.SceneSaver.Pop());
    }

    public void Exit() {
        Debug.Log("Scene End");
    }

    public void SelectUnit() {
        DataPather.FileData = GetComponent<UnitView>().FileName;
        Debug.Log(DataPather.FileData + " is Clicked");
        Gate("Unit_Dtailer");
    }

    //customFunc::private
    //void

    //string
    private string BasicBtnName() {
        string Name = null;
        btn = null;
        btn = GetComponent<Button>();
        return Name = btn.name;
    }
}