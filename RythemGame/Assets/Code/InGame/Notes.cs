using UnityEngine;
using UnityEngine.EventSystems;

public class Notes : MonoBehaviour, IPointerClickHandler{
    public float ScoreLIne=0;
    public float ChordLine=0;
    public float TicPerf=0;
    public char NoteData='e';

    Animation Anim;

    public void OnPointerClick(PointerEventData PED) {
        if (PED.button == PointerEventData.InputButton.Left) {
            float shock= Mathf.Abs(TicPerf - ComCloak.MetroClok);
            ScoreT.perfect += 25;
            if (shock  < 0.0625) {
                Debug.Log(gameObject.name + " : Master, "+string.Format("{0:N3}", shock)+"t");
                ScoreT.TScore += 25;
                Destroy(gameObject);
            } else if (shock < 0.125) {
                Debug.Log(gameObject.name + " : Advenced, " + string.Format("{0:N3}", shock) + "t");
                ScoreT.TScore += 9;
                Destroy(gameObject);
            } else {
                Debug.Log(gameObject.name + " : Bombing, " + string.Format("{0:N3}", shock) + "t");
                ScoreT.TScore += 1;
                Destroy(gameObject);
            }
        }
    }

    private void Update() {
        if (TicPerf + 0.25 < ComCloak.MetroClok) {
            Debug.Log(gameObject.name + " : Unclicked");
            Destroy(gameObject);
        }
    }
}