using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiTrash01 : MonoBehaviour{

    GameObject obj;
    private void Start(){
        obj = GameObject.Find("Line");
    }
    private void Update(){
        obj.transform.Rotate(new Vector3(0,0,-0.05f));
    }
    private void OnTriggerEnter2D(Collider2D col2d){
        if (col2d.gameObject.CompareTag("NoteType1"))
            Debug.Log("touched");
    }

    private void OnTriggerExit2D(Collider2D col2d){
        if (col2d.gameObject.CompareTag("NoteType1"))
            Debug.Log("get out");
    }
}
