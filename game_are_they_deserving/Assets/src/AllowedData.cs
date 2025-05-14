
using System;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class AllowedData : MonoBehaviour {
    
    public string path;
    public TMP_Text allowed_data_text;

    Dictionary<string, int> allowed_data_array = new Dictionary<string, int>();

    void Start () {
        load_text();
    }

    void load_text() {
        path = "Assets/data/allowed.txt";
        
        allowed_data_text.text = "";

        string line;
        StreamReader reader = new StreamReader(path);
        while((line = reader.ReadLine()) != null) {
            allowed_data_text.text += line;
            allowed_data_text.text += "\n";

            string allowed_data_array_key_string = "";
            foreach(char c in line) {
                if (c == ':') {
                    break;
                }        
                allowed_data_array_key_string += c;
            }

            int allowed_data_array_value_integer;
            string allowed_data_array_value_string = "";
            bool start_storing_value = false;
            foreach(char c in line) {
                if (c == ';') {
                    break;
                }

                if (start_storing_value == true) {
                    allowed_data_array_value_string += c;
                }

                if (c == ':') {
                    start_storing_value = true;    
                }

            }
            allowed_data_array_value_integer = Int32.Parse(allowed_data_array_value_string);

            allowed_data_array.Add(allowed_data_array_key_string, allowed_data_array_value_integer);
        }

        foreach(var keyValuePair in allowed_data_array)
            Debug.Log($"Key is: {keyValuePair.Key}, Value is: {keyValuePair.Value}");
    }
}
