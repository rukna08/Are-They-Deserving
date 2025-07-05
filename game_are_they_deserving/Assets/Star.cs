
using UnityEngine;

public class Star : MonoBehaviour {
    
    void Start() {
        
        float random_scale = Random.Range(0.01f, 0.05f);
        
        transform.localScale = new Vector3(random_scale, random_scale, 1f);

    }

}
