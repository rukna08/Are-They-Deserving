
using System.Collections;
using UnityEngine;

public class Hand : MonoBehaviour {

    public float offset_x;
    public float offset_y;

    bool is_press_effect_processed;

    void Start() {
        is_press_effect_processed = true;
    }

    void Update() {
        hide_cursor();
        follow_mouse();
        if (Input.GetMouseButtonDown(0) && is_press_effect_processed == true) {
            is_press_effect_processed = false;
            StartCoroutine(press_effect());
        }
    }
    
    void follow_mouse() {

        Vector3 mousePositionScreen = Input.mousePosition;
        Vector3 mousePositionWorld = Camera.main.ScreenToWorldPoint(new Vector3(mousePositionScreen.x, mousePositionScreen.y, Camera.main.nearClipPlane));

        transform.position = new Vector2(mousePositionWorld.x + offset_x, mousePositionWorld.y + offset_y);        
    }

    void hide_cursor() {
        Cursor.visible = false;
    }

    IEnumerator press_effect() {
        float offset = 20;

        Vector3 rotation_state = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
        
        
        transform.eulerAngles = new Vector3(transform.eulerAngles.x + offset, transform.eulerAngles.y, transform.eulerAngles.z);
        

        yield return new WaitForSeconds(0.1f);

        transform.eulerAngles = rotation_state;

        is_press_effect_processed = true;
    }

}
