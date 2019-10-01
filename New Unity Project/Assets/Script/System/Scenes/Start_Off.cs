using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Off : MonoBehaviour {
	
	void Update(){
		GoNext ();
	}
	public void GoNext(){
		if(Input.GetMouseButton(0)){
			SceneManager.LoadScene ("Main");
		}
	}
}
