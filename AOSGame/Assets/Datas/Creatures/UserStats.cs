using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserStats : MonoBehaviour{
    //Damage, Atmor, protection and so on....
    public Dictionary<string, int> CombatableStat;

    //Life, Stem, Mana, and Regenerations
    public Dictionary<string, int> Survivable;
    
    //Force Stength... and so on
    public Dictionary<string, int> GrowableStat;

    private void Awake() {
        
    }

    private void Start() {
        
    }
}
