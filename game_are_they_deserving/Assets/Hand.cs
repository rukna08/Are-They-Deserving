
using UnityEngine;

public class Hand : MonoBehaviour {

    public float offset_x;
    public float offset_y;

    void Update() {
        hide_cursor();
        follow_mouse();
    }
    
    void follow_mouse() {

        Vector3 mousePositionScreen = Input.mousePosition;
        Vector3 mousePositionWorld = Camera.main.ScreenToWorldPoint(new Vector3(mousePositionScreen.x, mousePositionScreen.y, Camera.main.nearClipPlane));

        transform.position = new Vector2(mousePositionWorld.x + offset_x, mousePositionWorld.y + offset_y);        
    }

    void hide_cursor() {
        Cursor.visible = false;
    }

}
