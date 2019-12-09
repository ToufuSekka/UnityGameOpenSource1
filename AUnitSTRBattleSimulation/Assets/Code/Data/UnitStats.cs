using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitStats{
    // 000
    public string Nations, Gender, userName;

    // 010
    public int Max_Life, Life, LUP_Life, Regen_Life, RegenLUP_Life;

    // 020
    public string SpecialGage;
    public int Max_Gages, Gages, LUP_Gages, Regen_Gages, RegenLUP_Gages;

    // 030
    public string Armor;
    public int Defend, LUP_Defend, Protection;

    // 040
    public string Weapon, DamageType;
    public int Damage, LUP_Damage;

    // 050
    public int AttackSpeed, WalkSpeed, RunSpeed;

    // 060
    public Specialist Specialist;
    public Ability[] ability;

    public UnitStats(string[] StatData) {

    }
}
