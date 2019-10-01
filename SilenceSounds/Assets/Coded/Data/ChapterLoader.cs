using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChapterLoader : MonoBehaviour{

    public string ChapName, Description;
    public Image Sportlite;
    Text[] texts;

    private void Start() {
        texts = new Text[2];
        texts[0] = transform.Find("Subject").GetComponent<Text>();
        texts[1] = transform.Find("Description").GetComponent<Text>();

        texts[0].text = ChapName;
        texts[1].text = Description;
    }
}