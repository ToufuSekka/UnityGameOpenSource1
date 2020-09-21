using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour{

    private void Awake() {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(1280, 720,true);
    }
}
