using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Start_Scene : MonoBehaviour {
    string keyword=null, data = null, Server = null, Newer= null;
    Text LogViwer;
    InputField IDGetter;
	UnityWebRequest UWR;

	void Start () {
        keyword = "tester";
        Server = "http://localhost:8080/UnityDataTrasistor/LogOnData?" + "User=" + keyword;
        StartCoroutine(Sender());
        StartCoroutine(Caller());
    }
    void Update() {
        
    }

    //if StartButton Clicked, check UserIDData.
    public void StartButton(){
		//Data check
		if (PlayerPrefs.HasKey ("IDKey")) {

			//When have datas, Read Database on Server
			keyword = PlayerPrefs.GetString("IDKey");
            Server = "http://localhost:8080/UnityDataTrasistor/LogOnData?" + "User=" + keyword;

            //use database
            StartCoroutine(Sender());
            StartCoroutine(Caller());

        } else {
            //When Empty Data, Create data
            Newer = IDGetter.text;
            PlayerPrefs.SetString("IDKey", Newer);
            Server = "http://localhost:8080/UnityDataTrasistor/CreateData?" + "User=" + Newer;
            //use database
            StartCoroutine(Sender());
            StartCoroutine(Caller());
        }
	}

	//if AccountChange Clicked
	void ChangeAccount(){
		//open Changer
	}
		
	void NextScene(){
		//check Gameversion, if incorrect version change to correct version.

		//Scene change [MainMenu]
	}

	//When click EXIT Button, Ask "will you really exit the game?"
	void EXITButton(){}

    IEnumerator Sender() {
        UWR = UnityWebRequest.Post(Server, "");
        Debug.Log(keyword);

        yield return UWR.SendWebRequest();

        if (UWR.isHttpError || UWR.isNetworkError) {
            Debug.Log(UWR.error);
        }
    }

	IEnumerator Caller(){
        UWR = UnityWebRequest.Get (Server);
        
        UWR.downloadHandler = new DownloadHandlerBuffer ();
		yield return UWR.SendWebRequest();

		if (UWR.isHttpError || UWR.isNetworkError) {
			Debug.Log(UWR.error);
			//Anything.text = UWR.error;
		} else {
			data = UWR.downloadHandler.text;

			for(int i =0;i < TestDiv(data).Length-1;i++){
				//Anything.text += " " + TestDiv (data) [i];
				Debug.Log ((i+1)+" : "+TestDiv (data)[i]);
			}
			Debug.Log (UWR.downloadHandler.text);
		}
	}

	string[] TestDiv(string fullData){
		string[] output;
		char[] div={';'};
		output = fullData.Split (div);

		return output;
	}
}