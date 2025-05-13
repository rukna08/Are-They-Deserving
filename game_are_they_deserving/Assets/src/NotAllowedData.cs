
using System.IO;
using TMPro;
using UnityEngine;

public class NotAllowedData : MonoBehaviour {
    
    public string path;
    public TMP_Text not_allowed_text;

    void Start () {
        load_text();
    }

    void load_text() {
        path = "Assets/data/not_allowed.txt";
        
        not_allowed_text.text = "";

        string line;
        StreamReader reader = new StreamReader(path);
        while((line = reader.ReadLine()) != null) {
            not_allowed_text.text += line;
            not_allowed_text.text += "\n";
        }
    }

}
