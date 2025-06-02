
using TMPro;
using UnityEngine;

public class Judgement : MonoBehaviour {
    
    int judgement_score;
    public TMP_Text judgement_score_text;
    
    public PlanetData planet_data;
    public AllowedData allowed_data;
    public NotAllowedData not_allowed_data;

    void Start() {
        calculate_judgement_score();
    }

    public void calculate_judgement_score() {
        judgement_score = 0;

        for(int i = 0; i < planet_data.planet_data_array.Count; i++) {
            if (allowed_data.allowed_data_array.ContainsKey(planet_data.planet_data_array[i])) {
                judgement_score += allowed_data.allowed_data_array[planet_data.planet_data_array[i]];
                Debug.Log("Allowed Data contains " + planet_data.planet_data_array[i] + " with weight: " + allowed_data.allowed_data_array[planet_data.planet_data_array[i]]);
            }

            if (not_allowed_data.not_allowed_data_array.ContainsKey(planet_data.planet_data_array[i])) {
                judgement_score -= not_allowed_data.not_allowed_data_array[planet_data.planet_data_array[i]];
                Debug.Log("Not Allowed Data contains " + planet_data.planet_data_array[i] + " with weight: " + not_allowed_data.not_allowed_data_array[planet_data.planet_data_array[i]]);
            }
        }

        judgement_score_text.text = "Judgement Score: " + judgement_score.ToString();
    }

    public void load_next_planet() {
        planet_data.load_text();
        calculate_judgement_score();
    }
}
