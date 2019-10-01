using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BTNCNTL : MonoBehaviour{

    Button BTN;
    ANICNTL anicon = new ANICNTL();
    DATACNTL datacon = new DATACNTL();
    DataPather DatPth = new DataPather();

    bool checker = false;
    //callback

    //customFunc::public
    //void
    public void SceneButton() {
        Debug.Log("Goto " + CFuncNS());
        SceneManager.LoadScene(CFuncNS());
    }

    public void BacAExt() {
        //
    }

    public void StartGame() {
        SceneManager.LoadScene("InGame");
        DatPth.ChapterBucket(CFuncNS());
    }

    //preTestFunc
    public void NameChecker() {
        Debug.Log("Checked " + CFuncNS());
    }

    //customFunc::private
    //string
    private string CFuncNS() {
        string Name = null;
        BTN = GetComponent<Button>();
        Name = BTN.name;
        return Name;
    }

    //bool
    private bool BoolReturner() {
        return checker = !checker;
    }
}