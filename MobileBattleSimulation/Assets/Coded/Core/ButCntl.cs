using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButCntl : MonoBehaviour{
    Button btn;
    string TestClicked="";
    //Callback

    //customFunc::public

    //void
    public void Gate(string SceneName) {
        DatCntl.ScreenSaver.Push(SceneManager.GetActiveScene().name);
        if(SceneName == null || SceneName.Equals(""))
            SceneManager.LoadScene(BasicBtnName());
        else
            SceneManager.LoadScene(SceneName);
    }

    public void BAECntl() {
        if (DatCntl.ScreenSaver.Count.Equals(0))
            Exit();
        else
            BackDoor();
    }

    public void BackDoor() {
        SceneManager.LoadScene(DatCntl.ScreenSaver.Pop());
    }

    public void Exit() {
        Debug.Log("Scene End");
    }

    public void SelectUnit() {
        TestClicked = GetComponent<UnitView>().FileName;
        Debug.Log(TestClicked + " is Clicked");
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