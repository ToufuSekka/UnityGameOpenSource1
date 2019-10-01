using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButCntl : MonoBehaviour{
    DataPather DP =new DataPather();
    
    //Callback

    //customFunc::public

    //void
    public void Gate() {
        DP.ScenePush(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(BasicBtnName());
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

    }

    //customFunc::private
    //void

    //string
    private string BasicBtnName() {
        string Name = null;
        Button btn = null;
        btn = GetComponent<Button>();
        return Name = btn.name;
    }
}