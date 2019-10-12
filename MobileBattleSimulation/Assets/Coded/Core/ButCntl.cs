using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButCntl : MonoBehaviour{
    DataPather DP =new DataPather();
    Button btn;
    //Callback

    //customFunc::public

    //void
    public void Gate(string SceneName) {
        DP.ScenePush(SceneManager.GetActiveScene().name);
        if(SceneName == null || SceneName.Equals(""))
            SceneManager.LoadScene(BasicBtnName());
        else
            SceneManager.LoadScene(SceneName);
    }

    public void BAECntl() {
        if (DP.SaverCounter("Scene") == 0)
            Exit();
        else
            BackDoor();
       
    }

    public void BackDoor() {
        SceneManager.LoadScene(DP.ScenePop());
    }

    public void Exit() {
        Debug.Log("Scene End");
    }

    public void SelectUnit() {
        Debug.Log(BasicBtnName()+" is Clicked");
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