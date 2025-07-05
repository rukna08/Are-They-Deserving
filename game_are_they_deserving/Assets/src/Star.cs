
using UnityEngine;
using System.Collections;


public class Star : MonoBehaviour {
    
    public bool fluctuates;
    public float fluctuation_rate;
    public float alpha;
    public int can_have_unique_color;

    void OnEnable() {
        if (fluctuates) {
            StartCoroutine(fluctuate());    
        }
        
    }

    void Start() {
        
        float random_scale = Random.Range(0.01f, 0.05f);
        
        transform.localScale = new Vector3(random_scale, random_scale, 1f);

        if (Random.Range(0, 2) == 0) {
            fluctuates = false;
        } else {
            fluctuates = true;
        }

        alpha = 1f;

        //                                  [0, 3)
        can_have_unique_color = Random.Range(0, 3);
        // sample_space = 0, 1, 2           P(0) = 1 / 3 = 33%
        if (can_have_unique_color == 0) {
            GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), alpha);

        }


        if (fluctuates){
            
            fluctuation_rate = Random.Range(0f, 0.7f);
            StartCoroutine(fluctuate());
        }


    }


    IEnumerator fluctuate() {

        while (true) {
            // Fade out
            while (alpha > 0f) {
                alpha -= fluctuation_rate * Time.deltaTime;
                alpha = Mathf.Clamp01(alpha);
                GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, alpha);
                yield return null;
            }

            // Fade in
            while (alpha < 1f) {
                alpha += fluctuation_rate * Time.deltaTime;
                alpha = Mathf.Clamp01(alpha);
                GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, alpha);
                yield return null;
            }
        }

    }



}
