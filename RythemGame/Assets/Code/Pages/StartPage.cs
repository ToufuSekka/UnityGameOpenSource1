using UnityEngine;
using UnityEngine.UI;

public class StartPage : MonoBehaviour{
    void Start() {
        gameObject.GetComponent<Network>().NetConnect();
    }
}