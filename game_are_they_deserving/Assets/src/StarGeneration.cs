
using UnityEngine;

public class StarGeneration : MonoBehaviour {
    
    public GameObject star;
    public int number_of_stars;

    void Start() {

        kill_all_stars();
        generate_stars();

    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.G)) {
            kill_all_stars();
            generate_stars();    
        }

    }

    void generate_stars() {
        number_of_stars = Random.Range(10, 100);
        
        for(int i = 0; i < number_of_stars; i++) {

            float x = Random.Range(-10f, 10f);
            float y = Random.Range(-5f, 5f);

            Instantiate(star, new Vector3(x, y, 1f), Quaternion.identity, transform);

        }

    }

    void kill_all_stars() {
        for(int i = 0; i < transform.childCount; i++) {
            Destroy(transform.GetChild(i).gameObject);
        }
    }

    
}
