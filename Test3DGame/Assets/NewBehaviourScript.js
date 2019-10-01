#pragma strict

function Start () {
    
   
}

function Update () {
    if(Input.GetKeyDown("w")){
        transform.Translate(Time.deltaTime * 15);
    }
}

function OnGUI(){}
