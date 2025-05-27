
using TMPro;
using UnityEngine;

public class ButtonLogic : MonoBehaviour {

    public GameObject chakras_ui;
    public GameObject manuscript_ui;
    public GameObject planet_ui;
    public GameObject trade_ui;

    public void Start() {
        enable_manuscript_ui();
    }

    public void enable_manuscript_ui() {
        manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.b, 255);
        manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.b, 255);
        manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.b, 255);
        manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.b, 255);
        manuscript_ui.transform.GetChild(0).GetComponent<StutterUI>().enabled = true;
        manuscript_ui.transform.GetChild(1).GetComponent<StutterUI>().enabled = true;
        manuscript_ui.transform.GetChild(2).GetComponent<StutterUI>().enabled = true;
        manuscript_ui.transform.GetChild(3).GetComponent<StutterUI>().enabled = true;

        planet_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(planet_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.r, planet_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.g, planet_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.b, 0);
        planet_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = new Color(planet_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.r, planet_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.g, planet_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.b, 0);
        planet_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color = new Color(planet_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.r, planet_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.g, planet_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.b, 0);
        planet_ui.transform.GetChild(0).GetComponent<StutterUI>().enabled = false;
        planet_ui.transform.GetChild(1).GetComponent<StutterUI>().enabled = false;
        planet_ui.transform.GetChild(2).GetComponent<StutterUI>().enabled = false; 
        
        trade_ui.SetActive(false);

        chakras_ui.SetActive(true);
    }

    public void enable_planet_ui() {
        manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.b, 0);
        manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.b, 0);
        manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.b, 0);
        manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.b, 0);
        manuscript_ui.transform.GetChild(0).GetComponent<StutterUI>().enabled = false;
        manuscript_ui.transform.GetChild(1).GetComponent<StutterUI>().enabled = false;
        manuscript_ui.transform.GetChild(2).GetComponent<StutterUI>().enabled = false;
        manuscript_ui.transform.GetChild(3).GetComponent<StutterUI>().enabled = false;
        
        planet_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(planet_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.r, planet_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.g, planet_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.b, 255);
        planet_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = new Color(planet_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.r, planet_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.g, planet_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.b, 255);
        planet_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color = new Color(planet_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.r, planet_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.g, planet_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.b, 255);
        planet_ui.transform.GetChild(0).GetComponent<StutterUI>().enabled = true;
        planet_ui.transform.GetChild(1).GetComponent<StutterUI>().enabled = true;
        planet_ui.transform.GetChild(2).GetComponent<StutterUI>().enabled = true;

        trade_ui.SetActive(false);

        chakras_ui.SetActive(false);
    }

    public void enable_trade_ui() {
        manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.b, 0);
        manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.b, 0);
        manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.b, 0);
        manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color = new Color(manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.r, manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.g, manuscript_ui.transform.GetChild(3).GetComponent<TextMeshProUGUI>().color.b, 0);
        manuscript_ui.transform.GetChild(0).GetComponent<StutterUI>().enabled = false;
        manuscript_ui.transform.GetChild(1).GetComponent<StutterUI>().enabled = false;
        manuscript_ui.transform.GetChild(2).GetComponent<StutterUI>().enabled = false;
        manuscript_ui.transform.GetChild(3).GetComponent<StutterUI>().enabled = false;
        
        planet_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = new Color(planet_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.r, planet_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.g, planet_ui.transform.GetChild(0).GetComponent<TextMeshProUGUI>().color.b, 0);
        planet_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color = new Color(planet_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.r, planet_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.g, planet_ui.transform.GetChild(1).GetComponent<TextMeshProUGUI>().color.b, 0);
        planet_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color = new Color(planet_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.r, planet_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.g, planet_ui.transform.GetChild(2).GetComponent<TextMeshProUGUI>().color.b, 0);
        planet_ui.transform.GetChild(0).GetComponent<StutterUI>().enabled = false;
        planet_ui.transform.GetChild(1).GetComponent<StutterUI>().enabled = false;
        planet_ui.transform.GetChild(2).GetComponent<StutterUI>().enabled = false;

        trade_ui.SetActive(true);

        chakras_ui.SetActive(false);
    }

}
