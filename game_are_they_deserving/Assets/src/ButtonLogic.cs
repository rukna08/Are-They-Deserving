
using UnityEngine;

public class ButtonLogic : MonoBehaviour {

    public GameObject manuscript_ui;
    public GameObject planet_ui;
    public GameObject chakras_ui;
    
    public void enable_manuscript_ui() {
        manuscript_ui.SetActive(true);
        chakras_ui.SetActive(true);
        planet_ui.SetActive(false);
    }

    public void enable_planet_ui() {
        manuscript_ui.SetActive(false);
        chakras_ui.SetActive(false);
        planet_ui.SetActive(true);
    }

}
