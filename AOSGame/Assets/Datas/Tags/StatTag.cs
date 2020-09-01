using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatTag : int {
    //survival
    Life = 0x00, LifeRegen = 0x01, Injury = 0x02,
    Stemina = 0x03, StemRegen = 0x04, Physical = 0x05,
    Mana = 0x06, ManaRegen = 0x07, Hunger = 0x08,
    
    //combatable
    Attacks = 0x010 ,Critical= 0x11, Dadend=0x12, Protection =0x13,
}
