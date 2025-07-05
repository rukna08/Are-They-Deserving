
using UnityEngine;
using TMPro;

public class CloseConsole : MonoBehaviour {

    public GameObject chakras;
    public GameObject manuscript_ui;
    public GameObject planet_ui;
    public GameObject trade_ui;
    public GameObject bottom_panel;
    public GameObject scroll;
    public GameObject hand;
    public GameObject reality;

    public bool is_console_active;

    public TMP_Text this_button_text;

    void Start() {
        is_console_active = true;
    }

    public void open_and_close_console() {
        if (is_console_active) {
            chakras.SetActive(false);
            manuscript_ui.SetActive(false);
            planet_ui.SetActive(false);
            trade_ui.SetActive(false);
            bottom_panel.SetActive(false);
            scroll.SetActive(false);
            hand.SetActive(false);
            reality.SetActive(true);
            is_console_active = false;
            this_button_text.text = "Open Console"; 
        } else if (!is_console_active) {
            manuscript_ui.SetActive(true);
            planet_ui.SetActive(true);
            bottom_panel.SetActive(true);
            scroll.SetActive(true);
            hand.SetActive(true);
            reality.SetActive(false);
            is_console_active = true;
            this_button_text.text = "Close Console";
        }
    }
}
