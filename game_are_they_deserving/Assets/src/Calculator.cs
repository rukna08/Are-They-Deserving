
using UnityEngine;

using System;
using System.Data;
using System.Collections;

using TMPro;


public class Calculator : MonoBehaviour {
    
    public GameObject calculator_inputfield;
    string expression;

    void Update() {
        expression = calculator_inputfield.GetComponent<TMP_InputField>().text;
    }

    public void calculate() {
        var result = new DataTable().Compute(expression, null);
        calculator_inputfield.GetComponent<TMP_InputField>().text = result.ToString();
    }

    public void clear() {
        calculator_inputfield.GetComponent<TMP_InputField>().text = "";
    }
}
