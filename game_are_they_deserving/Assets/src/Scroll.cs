
using UnityEngine;

public class Scroll : MonoBehaviour {
    
    public GameObject manuscript_ui;
    public GameObject chakra_holder;
    
    float offset;
    public float chakra_offset;

    void Start() {
        offset = 20f;
    }

    void Update() {
        

        // Scroll up
        if (chakra_holder.transform.position.y > 0.4f) {
            
            if (Input.GetAxis("Mouse ScrollWheel") > 0f) {
                manuscript_ui.transform.position = new Vector3(manuscript_ui.transform.position.x,
                                                               manuscript_ui.transform.position.y - offset,
                                                               manuscript_ui.transform.position.z);
                chakra_holder.transform.position = new Vector3(chakra_holder.transform.position.x,
                                                               chakra_holder.transform.position.y - chakra_offset,
                                                               chakra_holder.transform.position.z);
            }
        
        }


        // Scroll Down
        if (Input.GetAxis("Mouse ScrollWheel") < 0f) {
            manuscript_ui.transform.position = new Vector3(manuscript_ui.transform.position.x,
                                                           manuscript_ui.transform.position.y + offset,
                                                           manuscript_ui.transform.position.z);
            chakra_holder.transform.position = new Vector3(chakra_holder.transform.position.x,
                                                           chakra_holder.transform.position.y + chakra_offset,
                                                           chakra_holder.transform.position.z);
        }

    }
}
