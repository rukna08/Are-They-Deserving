
using System.IO;
using TMPro;
using UnityEngine;

public class AllowedData : MonoBehaviour {
    
    public string path;
    public TMP_Text allowed_data_text;

    void Start () {
        load_text();
    }

    void load_text() {
        path = "Assets/data/allowed.txt";
        
        allowed_data_text.text = "";

        string line;
        StreamReader reader = new StreamReader(path);
        while((line = reader.ReadLine()) != null) {
            Debug.Log(line);
            allowed_data_text.text += line;
            allowed_data_text.text += "\n";
        }
    }

}
