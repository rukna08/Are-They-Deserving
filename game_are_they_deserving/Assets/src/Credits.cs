
using TMPro;
using UnityEngine;

public class Credits : MonoBehaviour {
    public float credits;

    TMP_Text credits_text;

    public void Start() {
        credits_text = GetComponent<TMP_Text>();
        credits = 50.46f;
    }

    private void Update() {
        
        credits_text.text = "Credits: " + credits.ToString("0.00");

    }
}
