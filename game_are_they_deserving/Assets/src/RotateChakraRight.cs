
using System.Collections;
using UnityEngine;

public class RotateChakraRight : MonoBehaviour {
    
    float rotation_amount;
    bool ray_has_started_right_rotation = false;
    public bool is_chakra_1;
    public bool is_chakra_2;
    public bool is_chakra_3;

    RaycastHit2D hit;

    void Update() {
        if(Input.GetKeyDown(KeyCode.D)) {
            StartCoroutine(rotate_right());
        }

        if(Input.GetKeyDown(KeyCode.A)) {
            StartCoroutine(rotate_left());
        }

        hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        
        if (!ray_has_started_right_rotation) {
            if (hit.collider != null) {
                if (is_chakra_1) {
                    if (hit.collider.name == "Chakra 1") {
                        ray_has_started_right_rotation = true;
                        StartCoroutine(rotate_right());
                    }
                } else if (is_chakra_2) {
                    if (hit.collider.name == "Chakra 2") {
                        ray_has_started_right_rotation = true;
                        StartCoroutine(rotate_right());
                    }
                } else if (is_chakra_3) {
                    if (hit.collider.name == "Chakra 3") {
                        ray_has_started_right_rotation = true;
                        StartCoroutine(rotate_right());
                    }
                }
            }
        }
    
    }

    IEnumerator rotate_right() {
        while (rotation_amount != -181f) {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, rotation_amount, transform.eulerAngles.z);
            rotation_amount -= 1.0f;    
            yield return null;
        }
        Debug.Log("Moved Right");
        yield return new WaitForSeconds(1f);
        StartCoroutine(rotate_left());
        ray_has_started_right_rotation = false;
    }

    IEnumerator rotate_left() {
        while (rotation_amount != 1f) {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, rotation_amount, transform.eulerAngles.z);
            rotation_amount += 1.0f;
            yield return null;
        }
        Debug.Log("Moved Left");
    }
}
