
using TMPro;
using UnityEngine;

public class Energy : MonoBehaviour {
    
    public float energy;

    TMP_Text energy_text;

    void Start() {
        energy = 150000f;
        energy_text = GetComponent<TMP_Text>();
    }

    void Update() {
        energy_text.text = "Energy: " + energy.ToString();

        energy -= 0.1f;
    }

}
