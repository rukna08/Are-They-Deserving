
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class GridScript : MonoBehaviour {

    public GameObject grid_unit;

    public int grid_width;
    public int grid_height;

    void generate_grid() {
        clear_grid();

        for(int i = 0; i < grid_width; i++) {
            for(int j = 0; j < grid_height; j++) {
                Instantiate(grid_unit, new Vector3(transform.position.x + i, transform.position.y + j, 1f), Quaternion.identity, transform);
            }
        }
    }

    void clear_grid() {
        for(int i = transform.childCount - 1; i >= 0; i--) {
            DestroyImmediate(transform.GetChild(i).gameObject, true);
        }
    }

    #if UNITY_EDITOR
        [CustomEditor(typeof(GridScript))]
        public class GridScriptEditor : Editor {
            public override void OnInspectorGUI() {
                base.OnInspectorGUI();

                var instance = (GridScript)target;

                EditorGUILayout.Space();
                EditorGUILayout.Space();
                EditorGUILayout.Space();

                if(GUILayout.Button("Generate Grid")) {
                    instance.generate_grid();
                }
                if(GUILayout.Button("Clear Grid")) {
                    instance.clear_grid();
                }
            }
        }
    #endif
}
