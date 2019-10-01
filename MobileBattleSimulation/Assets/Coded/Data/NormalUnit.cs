using UnityEngine;

[CreateAssetMenu(fileName ="NormalUnit", menuName = "NormalUnitData")]
public class NormalUnit : ScriptableObject {

    //Basic Data
    public string Name = null, Description = null;
    public UnitType U_Type;
    public ArmorType A_Type;
    public WeaponType W_Type;
    public int Life, MaxLife;
    public int Damage;
    public int AtkRange;
    public int SupRange;
    public int MarMove;
    public int BattleMove;
    public float AttackSpd;
    public int CreaRes, Supply, Weight;

    public Abilities Abil;
    public int BuyUnit;
    public bool Unlock;

    //Viweing Data
    public Sprite Profile, Stratagy;
    public Animation Move, Attack, Death, Wait;
}
