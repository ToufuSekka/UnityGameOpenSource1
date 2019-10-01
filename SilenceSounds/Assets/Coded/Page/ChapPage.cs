using UnityEngine;

public class ChapPage : MonoBehaviour{
    DATACNTL datact = new DATACNTL();

    //callback
    void Start() {
        datact.ChapSpray("Chapter");
    }
}
