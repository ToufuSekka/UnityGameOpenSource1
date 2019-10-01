using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnitView : MonoBehaviour{
    public string TName;
    Image SportLite;
    Text Name;

    private void Start() {
        Name = transform.Find("Name").GetComponent<Text>();
        Name.text = gameObject.name;
    }
}
