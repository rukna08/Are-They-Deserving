
using TMPro;
using UnityEngine;

public class Judgement : MonoBehaviour {
    
    int judgement_score;
    public TMP_Text judgement_score_text;

    void Start() {
        judgement_score = 0;
    }

    void Update() {
        judgement_score_text.text = "Judgement Score: " + judgement_score.ToString();
    }
}
