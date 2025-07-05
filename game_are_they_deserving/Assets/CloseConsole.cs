
using UnityEngine;

public class CloseConsole : MonoBehaviour {

    public GameObject manuscript_ui;
    public GameObject planet_ui;
    public GameObject trade_ui;
    public GameObject bottom_panel;
    public GameObject scroll;

    public void close_console() {
        manuscript_ui.SetActive(false);
        planet_ui.SetActive(false);
        trade_ui.SetActive(false);
        bottom_panel.SetActive(false);
        scroll.SetActive(false);
    }

}
