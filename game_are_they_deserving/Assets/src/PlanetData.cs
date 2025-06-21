
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class PlanetData : MonoBehaviour {
    
    public string path;
    public TMP_Text planet_data_text;

    public List<string> planet_data_array;

    void Start() {
        planet_data_array = new List<string>();
        load_text();
    }

    public void load_text() {
        planet_data_array.Clear();

        // Updated path to StreamingAssets
        path = Path.Combine(Application.streamingAssetsPath, "base.txt");

        planet_data_text.text = "";

        if (!File.Exists(path)) {
            Debug.LogError("PlanetData file not found at: " + path);
            return;
        }

        string[] lines = File.ReadAllLines(path);
        foreach (string line in lines) {
            int dice_roll = Random.Range(0, 3);
            if (dice_roll == Random.Range(0, 3)) {
                planet_data_text.text += line + "\n";
                planet_data_array.Add(line);
            }
        }
    }

}
