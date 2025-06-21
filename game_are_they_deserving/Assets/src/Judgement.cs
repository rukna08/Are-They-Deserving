
using System.Collections;
using TMPro;
using UnityEngine;

public class Judgement : MonoBehaviour {
    
    int judgement_score;
    public TMP_Text judgement_score_text;
    
    public PlanetData planet_data;
    public AllowedData allowed_data;
    public NotAllowedData not_allowed_data;

    public GameObject kill_button;
    public GameObject next_planet_button;

    void Start() {
        calculate_judgement_score();
    }

    public void calculate_judgement_score() {
        judgement_score = 0;

        for(int i = 0; i < planet_data.planet_data_array.Count; i++) {
            if (allowed_data.allowed_data_array.ContainsKey(planet_data.planet_data_array[i])) {
                judgement_score += allowed_data.allowed_data_array[planet_data.planet_data_array[i]];
                //Debug.Log("Allowed Data contains " + planet_data.planet_data_array[i] + " with weight: " + allowed_data.allowed_data_array[planet_data.planet_data_array[i]]);
            }

            if (not_allowed_data.not_allowed_data_array.ContainsKey(planet_data.planet_data_array[i])) {
                judgement_score -= not_allowed_data.not_allowed_data_array[planet_data.planet_data_array[i]];
                //Debug.Log("Not Allowed Data contains " + planet_data.planet_data_array[i] + " with weight: " + not_allowed_data.not_allowed_data_array[planet_data.planet_data_array[i]]);
            }
        }

        judgement_score_text.text = "Judgement Score: " + judgement_score.ToString();
    }

    void disable_ui() {
        kill_button.SetActive(false);
        next_planet_button.SetActive(false);
    }

    void enable_ui() {
        kill_button.SetActive(true);
        next_planet_button.SetActive(true);
    }

    IEnumerator reach_next_planet() {
        disable_ui();

        Debug.Log("Travelling to next planet!");
        
        yield return new WaitForSeconds(5f);
        
        Debug.Log("Planet reached!!");
        
        enable_ui();
        planet_data.load_text();
        calculate_judgement_score();
    }

    public void load_next_planet() {
        StartCoroutine(reach_next_planet());
    }
}
