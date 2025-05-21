
using UnityEngine;

public class RotateChakraCircular : MonoBehaviour {
    
    float rotation_amount;
    public float rotation_speed;

    void Start () {
        rotation_amount = transform.eulerAngles.z;
        //rotation_speed = 0.2f;
    }

    void Update() {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, rotation_amount);
        rotation_amount -= rotation_speed;
    }
}
