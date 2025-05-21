
using System;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class NotAllowedData : MonoBehaviour {
    
    public string path;
    public TMP_Text not_allowed_data_text;

    Dictionary<string, int> not_allowed_data_array = new Dictionary<string, int>();

    void Start () {
        load_text();
    }

    void load_text() {
        path = "Assets/data/not_allowed.txt";
        
        not_allowed_data_text.text = "";

        string line;
        StreamReader reader = new StreamReader(path);
        while((line = reader.ReadLine()) != null) {

            string not_allowed_data_array_key_string = "";
            foreach(char c in line) {
                if (c == ':') {
                    break;
                }
                not_allowed_data_array_key_string += c;
            }

            int not_allowed_data_array_value_integer;
            string not_allowed_data_array_value_string = "";
            bool start_storing_value = false;
            foreach(char c in line) {
                if (c == ';') {
                    break;
                }

                if(start_storing_value == true) {
                    not_allowed_data_array_value_string += c;
                }

                if(c == ':') {
                    start_storing_value = true;
                }

            }

            not_allowed_data_array_value_integer = Int32.Parse(not_allowed_data_array_value_string);
            not_allowed_data_array.Add(not_allowed_data_array_key_string, not_allowed_data_array_value_integer);
        }

        foreach(var kvp in not_allowed_data_array) {
            string l = kvp.Key + ": " + kvp.Value;
            not_allowed_data_text.text += l;
            not_allowed_data_text.text += "\n";
        }
    }

}
