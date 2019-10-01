#pragma strict

import System.IO;
import UnityEngine.UI;


var Read : StreamReader;
var c : String;

function Start(){
    Read = StreamReader("Assets\\data.json");
    
    while(Read != null){
    
    c =Read.ReadLine();
    Debug.Log(c);
    
    }
}

function Update(){

}

