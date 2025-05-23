


using System.Collections;
using TMPro;
using UnityEngine;

public class StutterUI : MonoBehaviour {
    
    TMP_Text text;

    void Start() {
        text = GetComponent<TMP_Text>();

        StartCoroutine(stutter());
    }

    void OnEnable() {
        if (text == null) {
            text = GetComponent<TMP_Text>();
        }

        StartCoroutine(stutter());
    }

    void OnDisable() {
        StopAllCoroutines();
    }

    // Credit: Took help of ChatGPT to modify this code.
    IEnumerator stutter() {
               
         while (true) {
            int iterations = Random.Range(10, 300);
            // 50 rapid alpha changes
            for (int i = 0; i < iterations; i++) {
                text.color = new Color(text.color.r, text.color.g, text.color.b, Random.Range(0f, 1f));
                yield return null; // Change every frame (fast)
            }

            text.color = new Color(text.color.r, text.color.g, text.color.b, 1f);
            // Wait 2 seconds after each batch
            yield return new WaitForSeconds(Random.Range(5f, 60f));
        }

    }
}
