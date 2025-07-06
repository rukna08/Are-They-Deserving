
using UnityEngine;

public class GridScript : MonoBehaviour {

    public GameObject grid_unit;

    public int grid_width;
    public int grid_height;
    
    void Start() {
        generate_grid();
    }

    void generate_grid() {
        for(int i = 0; i < grid_width; i++) {
            for(int j = 0; j < grid_height; j++) {
                Instantiate(grid_unit, new Vector3(transform.position.x + i, transform.position.y + j, 1f), Quaternion.identity, transform);
            }
        }
    }
}
