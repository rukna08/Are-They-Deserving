
using UnityEngine;

public class Scroll : MonoBehaviour {
    
    public GameObject manuscript_ui;
    public GameObject chakra_holder;
    
    public float chakra_offset;

    void Update() {
        

        // Scroll up
        if (chakra_holder.transform.position.y >= 0.5f) {
            
            if (Input.GetAxis("Mouse ScrollWheel") > 0f) {
                manuscript_ui.transform.position = new Vector3(manuscript_ui.transform.position.x,
                                                               manuscript_ui.transform.position.y - chakra_offset,
                                                               manuscript_ui.transform.position.z);
                chakra_holder.transform.position = new Vector3(chakra_holder.transform.position.x,
                                                               chakra_holder.transform.position.y - chakra_offset,
                                                               chakra_holder.transform.position.z);
            }
        
        }


        // Scroll Down
        if (Input.GetAxis("Mouse ScrollWheel") < 0f) {
            manuscript_ui.transform.position = new Vector3(manuscript_ui.transform.position.x,
                                                           manuscript_ui.transform.position.y + chakra_offset,
                                                           manuscript_ui.transform.position.z);
            chakra_holder.transform.position = new Vector3(chakra_holder.transform.position.x,
                                                           chakra_holder.transform.position.y + chakra_offset,
                                                           chakra_holder.transform.position.z);
        }

    }
}
