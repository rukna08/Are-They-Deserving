
using TMPro;
using UnityEngine;

public class ButtonLogic : MonoBehaviour {

    public GameObject manuscript_ui;
    public GameObject planet_ui;
    public GameObject chakras_ui;
    
    public void enable_manuscript_ui() {
        manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.b, 255);
        manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.b, 255);
        manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.b, 255);
        manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.b, 255);

        chakras_ui.SetActive(true);
        planet_ui.SetActive(false);
    }

    public void enable_planet_ui() {
        manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.b, 0);
        manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.b, 0);
        manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.b, 0);
        manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.b, 0);

        chakras_ui.SetActive(false);
        planet_ui.SetActive(true);
    }

}
