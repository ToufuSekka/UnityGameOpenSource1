using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {
    Button btn = null;
    string Name = null;
    GameObject ob, cloner;

    Stack<string> SceneChaser = new Stack<string>();

    public void MainButton() {
        btn = GetComponent<Button>();
        Name = btn.name;
        SceneManager.LoadScene(Name);
        Name = null;
    }

    public void Backbutton() {
        SceneManager.LoadScene(Name);
        Name = null;
    }

    public void Exit() {
        Debug.Log("Exit Game");
    }

    public void UnitViwerButton() {
        btn = GetComponent<Button>();
        ob = GameObject.Find(btn.name);
        cloner = Instantiate(ob, new Vector3(0,0,-100),Quaternion.identity);
        cloner.name = "Cloner";
        DontDestroyOnLoad(ob);
        SceneManager.LoadScene("UnitInformator");
        SceneChaser.Push("UnitImformator");
        Debug.Log(ob.GetComponent<NormalUnit>().UnitDatas["Name"].ToString() +" : Clicked");
    }

    private void Update() {
        if (Input.GetKey(KeyCode.Escape)) {
            if (SceneChaser.Count == 0) {
                Exit();
            } else {
                Backbutton();
            }
        }
    }
}