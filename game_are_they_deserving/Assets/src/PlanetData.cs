
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

        path = "Assets/data/base.txt";

        planet_data_text.text = "";

        string line;
        StreamReader reader = new StreamReader(path);
        while((line = reader.ReadLine()) != null) {
            int dice_roll = Random.Range(0, 3);
            if (dice_roll == Random.Range(0, 3)) {
                planet_data_text.text += line + "\n";
                planet_data_array.Add(line);                
            }
        }
    }
}
