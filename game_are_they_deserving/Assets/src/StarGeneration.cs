
using UnityEngine;

#if UNITY_EDITOR

using UnityEditor;

#endif

public class StarGeneration : MonoBehaviour {
    
    public GameObject star;
    public int number_of_stars;

    void Start() {

        /*kill_all_stars();
        generate_stars();*/

    }

    void Update() {
        /*if (Input.GetKeyDown(KeyCode.G)) {
            kill_all_stars();
            generate_stars();    
        }*/

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
        for (int i = transform.childCount - 1; i >= 0; i--) {
            DestroyImmediate(transform.GetChild(i).gameObject, true);
        }

        number_of_stars = 0;
    }


    #if UNITY_EDITOR



        [CustomEditor(typeof(StarGeneration))]
        public class StarGenerationEditor : Editor {
            public override void OnInspectorGUI() {
                base.OnInspectorGUI();

                var instance = (StarGeneration)target;


                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();

                if(GUILayout.Button("Generate Stars")) {
                    instance.kill_all_stars();
                    instance.generate_stars();
                }


                if(GUILayout.Button("Clear Stars")) {
                    instance.kill_all_stars();
                }
            }
        }

    #endif

    
}
