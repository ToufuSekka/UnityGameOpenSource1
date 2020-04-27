using System.Collections;
using System.Collections.Generic;

using System.Xml;

using UnityEngine;

public class EXE_Effect : MonoBehaviour{
    List<EffectTags> Type;
    int[] EffectValues;
    Dictionary<int, int> Test;

    string EffectName = "Names";

    private void Awake() {
        Type = new List<EffectTags>();
    }

    private void Start() {
        Type.Add(0x00);
        EffectName = "";
    }

    private void Update() {
        
    }

    private void OnDestroy() {
        
    }
}
