using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatTag : int {
    Life = 0x00, LifeRegen = 0x01, Injury = 0x02,
    Stemina = 0x03, StemRegen = 0x04, Physical = 0x05,
    Mana = 0x06, ManaRegen = 0x07, Hunger = 0x08,
    
    //Growables
    Force = 0x10, Strength= 0x11, Knowledge = 0x12, Spirit= 0x13,
    Will = 0x14, Dex= 0x15, Abilitiy= 0x16, Luck = 0x17,
}
