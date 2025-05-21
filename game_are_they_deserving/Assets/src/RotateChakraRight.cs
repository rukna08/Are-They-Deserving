
using System.Collections;
using UnityEngine;

public class RotateChakraRight : MonoBehaviour {
    
    float rotation_amount;

    void Update() {
        if(Input.GetKeyDown(KeyCode.D)) {
            StartCoroutine(rotate_right());
        }

        if(Input.GetKeyDown(KeyCode.A)) {
            StartCoroutine(rotate_left());
        }
    }

    IEnumerator rotate_right() {
        while (rotation_amount != -180.5f) {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, rotation_amount, transform.eulerAngles.z);
            rotation_amount -= 0.5f;    
            yield return null;
        }
    }

    IEnumerator rotate_left() {
        while (rotation_amount != 0.5) {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, rotation_amount, transform.eulerAngles.z);
            rotation_amount += 0.5f;
            yield return null;
        }
    }
}
