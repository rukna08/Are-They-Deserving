
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
    public GameObject planet_data_ui;
    public GameObject planet_data_cross_ui;
    public GameObject kill_and_next_planet_cross_ui;

    public GameObject credits;

    public AudioSource evil_laughter_sfx;

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
        planet_data_ui.SetActive(false);
        planet_data_cross_ui.SetActive(true);
        kill_and_next_planet_cross_ui.SetActive(true);
    }

    void enable_ui() {
        kill_button.SetActive(true);
        next_planet_button.SetActive(true);
        planet_data_ui.SetActive(true);
        planet_data_cross_ui.SetActive(false);
        kill_and_next_planet_cross_ui.SetActive(false);
    }

    IEnumerator reach_next_planet(float time_to_reach_next_planet) {
        disable_ui();

        Debug.Log("Travelling to next planet!");
        
        
        yield return new WaitForSeconds(time_to_reach_next_planet);
        
        Debug.Log("Planet reached!!");
        
        enable_ui();
        planet_data.load_text();
        calculate_judgement_score();
    }

    public void kill_planet() {
        
        // When the judgement is correct.
        if(judgement_score < 0) {
            evil_laughter_sfx.Play();

            Debug.Log("Your Will Is Correct Supreme Executer.");
            Debug.Log("Planet Destroyed.");
            
            credits.GetComponent<Credits>().credits += 1;
            Debug.Log("1 Imperial Credit granted.");
            
        } else {
            Debug.Log("Your Will Is Incorrect Supreme Executer.");
            Debug.Log("Planet Destroyed.");
            credits.GetComponent<Credits>().credits -= 1;
            Debug.Log("1 Imperial Credit taken away.");
        }

        load_next_planet();
    
    }

    public void load_next_planet() {
        // Range is less now due to development mode.
        float time_to_reach_next_planet = Random.Range(0.1f, 1.5f);
        Debug.Log("To Reach Next Planet: " + time_to_reach_next_planet.ToString());
        StartCoroutine(reach_next_planet(time_to_reach_next_planet));
    }
}
