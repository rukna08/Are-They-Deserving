
using TMPro;
using UnityEngine;

public class Judgement : MonoBehaviour {
    
    int judgement_score;
    public TMP_Text judgement_score_text;
    
    public PlanetData planet_data;

    void Start() {
        judgement_score = 0;
    }

    void Update() {
        judgement_score_text.text = "Judgement Score: " + judgement_score.ToString();
        
        if (Input.GetKeyDown(KeyCode.P)) {
            for(int i = 0; i < planet_data.planet_data_array.Count; i++) {
                Debug.Log(planet_data.planet_data_array[i]);
            }
        }
    }
}
