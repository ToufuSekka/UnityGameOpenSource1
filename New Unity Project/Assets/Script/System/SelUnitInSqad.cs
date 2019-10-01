using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class SelUnitInSqad : MonoBehaviour{
    GameObject Unit, go;
    TextAsset Ta;
    XmlDocument XmlDoc = new XmlDocument();
    XmlNodeList XmlNL = null;
    int N = 0, x = -850, y = 250;

    private void Start() {
        Unit = Resources.Load("UnitData/Normal/Unit") as GameObject;
        Ta = (TextAsset)Resources.Load("UnitData/Normal/NormalUnit");
        Debug.Log(Ta.text);
        XmlDoc.LoadXml(Ta.text);
        XmlNL = XmlDoc.SelectNodes("UnitData/NomalUnit");
        /*
        foreach (XmlNode XmlNo in XmlNL) {
            Unit.GetComponent<NormalUnit>().Name = XmlNo.SelectSingleNode("Name").InnerText;
            Unit.GetComponent<NormalUnit>().U_Type = (UnitType)int.Parse(XmlNo.SelectSingleNode("UnitType").InnerText);
            Unit.GetComponent<NormalUnit>().A_Type = (ArmorType)int.Parse(XmlNo.SelectSingleNode("ArmorType").InnerText);
            Unit.GetComponent<NormalUnit>().W_Type = (WeaponType)int.Parse(XmlNo.SelectSingleNode("WeaponType").InnerText);
            Unit.GetComponent<NormalUnit>().Life = int.Parse(XmlNo.SelectSingleNode("Life").InnerText);
            Unit.GetComponent<NormalUnit>().Damage = int.Parse(XmlNo.SelectSingleNode("Damage").InnerText);
            Unit.GetComponent<NormalUnit>().AtkRange = int.Parse(XmlNo.SelectSingleNode("AktRange").InnerText);
            Unit.GetComponent<NormalUnit>().SupRange = int.Parse(XmlNo.SelectSingleNode("SupRange").InnerText);
            Unit.GetComponent<NormalUnit>().MarMove = int.Parse(XmlNo.SelectSingleNode("MarMove").InnerText);
            Unit.GetComponent<NormalUnit>().FightMove = int.Parse(XmlNo.SelectSingleNode("FightMove").InnerText);
            Unit.GetComponent<NormalUnit>().AttackSpd = float.Parse(XmlNo.SelectSingleNode("AttackSpd").InnerText);
            Unit.GetComponent<NormalUnit>().CreaRes = int.Parse(XmlNo.SelectSingleNode("CreaRes").InnerText);
            Unit.GetComponent<NormalUnit>().Supply = int.Parse(XmlNo.SelectSingleNode("Supply").InnerText);
            Unit.GetComponent<NormalUnit>().Weight = int.Parse(XmlNo.SelectSingleNode("Weight").InnerText);
            //Unit.GetComponent<NormalUnit>().Abil = XmlNo.SelectSingleNode("Name").InnerText;
            Unit.GetComponent<NormalUnit>().BuyUnit = int.Parse(XmlNo.SelectSingleNode("Buy").InnerText);
            Unit.GetComponent<NormalUnit>().Unlock = bool.Parse(XmlNo.SelectSingleNode("Lock").InnerText);



            if (Unit.GetComponent<NormalUnit>().Unlock == false) {
                x += 150;
                if (x > 650) {
                    y -= 150;
                    x = -850 + 150;
                }
                go = Instantiate(Unit, new Vector2(x, y), Quaternion.identity);
                go.name = Unit.GetComponent<NormalUnit>().Name;
                N++;
            }
        }
        */
    }
}
