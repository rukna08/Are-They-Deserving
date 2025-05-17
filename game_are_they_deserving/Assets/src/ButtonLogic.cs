
using UnityEngine;

public class ButtonLogic : MonoBehaviour {

    public GameObject manuscript_ui;
    public GameObject planet_ui;
    
    public void enable_manuscript_ui() {
        manuscript_ui.SetActive(true);
        planet_ui.SetActive(false);
    }

    public void enable_planet_ui() {
        manuscript_ui.SetActive(false);
        planet_ui.SetActive(true);
    }

}
