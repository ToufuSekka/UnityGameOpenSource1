using System.Collections;

using UnityEngine;
using UnityEngine.UI;

public class NormalUnit : MonoBehaviour{

    //Viweing Data
    public Sprite Portait, Profile, Stratagy;
    public Animation Move, Attack, Death, Wait;

    //Tested
    public Hashtable UnitDatas = new Hashtable();

    Image img;
    void Start() {
        img = GameObject.Find("Profile").GetComponent<Image>();
        img.sprite = Profile;
        
    }
}