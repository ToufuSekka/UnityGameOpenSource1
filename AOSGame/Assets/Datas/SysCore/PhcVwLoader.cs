using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PhcVwLoader : MonoBehaviour{

    /*
     we should set next stats :
     
     CharName, Image, Event
     SpiritSet => Spirits, SpiritName, Value, Percentage
     CharBuff, PoliticsStat
     
     PoliticStat is Viewing :
     Party, NonAgression, HousingItemRental
    */

    //Character
    string CharName;
    Image CharIMG;

    //Event
    string EventName;
    Image EventIMG;

    //SpiritSet
    public static Dictionary<string, int> Spirit = new Dictionary<string, int>();

    //Buff
    //Buff bff; : Uncreated

    //PoliticStat
    //Politics Polc; : Uncreated

    private void Start() {
        CharV();
    }

    //Specific View Set

    private void CharV() {
        //introGames....
    }

    private void EventV() {

    }

    private void SprV() {

    }

    private void BuffV() {
    }

    private void PoliV() {

    }
}
