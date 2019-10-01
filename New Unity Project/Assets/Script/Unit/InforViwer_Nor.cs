using System;
using UnityEngine;
using UnityEngine.UI;

enum ViwerType : int {
   Name = 1, Description = 0,
    UnitType = 2, ArmorType = 3, WeaponType = 4, Life = 5,
    Damage = 6, AtkRange = 7, SupRange = 8,
    MarMove = 9, FightMove = 10, AttackSpd =11,
    CreaRes = 12, Supply = 13, Weight = 14, Ability = 15,
}

public class InforViwer_Nor : MonoBehaviour{
    GameObject go;
    Text Viwer;
    Image Prof;

    string KeyName = "";
    private void Start() {
        NormalLoad();
    }

    void NormalLoad() {
        go = GameObject.Find("Cloner");
        Prof = GameObject.Find("Profile_V").GetComponent<Image>();
        Prof.sprite = go.GetComponent<NormalUnit>().Profile;
        
        for (int i = 1; i < 15; i++) {
            KeyName = Enum.GetName(typeof(ViwerType), i);
            Viwer = GameObject.Find(KeyName + "_V").GetComponent<Text>();
            Debug.Log(KeyName + " of :" +go.GetComponent<NormalUnit>().UnitDatas[KeyName].ToString());
            //Viwer.text = go.GetComponent<NormalUnit>().UnitDatas[Enum.GetName(typeof(ViwerType), i)].ToString();
        }
        Destroy(go);
        Debug.Log("Individual Noarmal Unit LoadComplete");
    }
}
