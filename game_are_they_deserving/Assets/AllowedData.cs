
using System.IO;
using TMPro;
using UnityEngine;

public class AllowedData : MonoBehaviour {
    
    public string path;
    public TMP_Text allowed_data_text;

    void Start () {
        path = "Assets/data/allowed.txt";
        
        string line;
        StreamReader reader = new StreamReader(path);
        while((line = reader.ReadLine()) != null) {
            Debug.Log(line);
            allowed_data_text.text += line;
            allowed_data_text.text += "\n";
        }
    }

}
