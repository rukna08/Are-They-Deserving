
using UnityEngine;

public class RealityInput : MonoBehaviour {
    
    public GameObject grid;
    public bool is_grid_active;

    void Start() {
        is_grid_active = false;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.G)) {
            is_grid_active = !is_grid_active;
        }

        if (is_grid_active) {
            grid.SetActive(true);
        } else {
            grid.SetActive(false);
        }
    }

}
