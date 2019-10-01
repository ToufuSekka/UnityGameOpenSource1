#pragma strict
import UnityEngine.UI;
var t : Text; 

function Start () {
    
}

var loading= 0.0f;

function Update () {
    t  = GetComponent.<Text>();
    loading += Time.deltaTime;

    if(loading>5.0f){
        t.text = "OK";
    }
    
    if(loading>5.0f&&Input.GetKey(KeyCode.Mouse0)){
        Application.LoadLevel("Main");
    }
    
}
