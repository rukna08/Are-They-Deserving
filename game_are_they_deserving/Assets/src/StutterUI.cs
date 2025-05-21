


using TMPro;
using UnityEngine;

public class StutterUI : MonoBehaviour {
    
    TMP_Text text;

    void Start() {
        text = GetComponent<TMP_Text>();
    }

    void Update() {
        stutter();
    }

    void stutter() {
        text.color = new Color(text.color.r, text.color.g, text.color.b, Random.Range(0.5f, 1f));
    }

}
