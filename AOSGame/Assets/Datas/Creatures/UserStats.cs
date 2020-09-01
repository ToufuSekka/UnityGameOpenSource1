using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserStats : MonoBehaviour{
    GameObject t;

    public struct SurvivableSpec {
        public int Life, Stemina, Mana;
        public float LifeRegen, Injury;
        public float StemRegen, Physical;
        public float ManaRegen, Hunger;
    
    }

    public struct CombatableSpec {
        public int Attacks, Critical, Dadend;
        public float Protection;
    }


    public SurvivableSpec Ss;
    public CombatableSpec Cs;

    private void Start() {
        statINIT();
        Debug.Log(Ss.Injury);
        Debug.Log(Ss.Life);
    }

    void statINIT() {
        Ss.Life = 80;
        Ss.Stemina = 10;
        Ss.Mana = 0;
        Cs.Attacks = 1;
        Cs.Critical = 0;
        Cs.Dadend = 1;
        Cs.Protection = 0;
    }
}