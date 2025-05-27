
using TMPro;
using UnityEngine;

public class Credits : MonoBehaviour {
    public int credits;

    TMP_Text credits_text;

    public void Start() {
        credits_text = GetComponent<TMP_Text>();
        credits = 5;
    }

    private void Update() {
        
        credits_text.text = "Credits: " + credits.ToString();

    }
}
