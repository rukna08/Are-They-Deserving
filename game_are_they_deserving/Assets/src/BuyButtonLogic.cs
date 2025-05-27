
using TMPro;
using UnityEngine;

public class BuyButtonLogic : MonoBehaviour {

    public GameObject energy;
    public GameObject credits;
    public TMP_Text trade_log;
    
    public void buy_item() {
        
        if (credits.GetComponent<Credits>().credits > 0) {
            if (transform.parent.name == "Energy") {
                trade_log.text += "\n";
                trade_log.text += "Bought 10000 energy for 1 credit";
                credits.GetComponent<Credits>().credits -= 1;
                energy.GetComponent<Energy>().energy += 10000f;
            }
        } else {
            trade_log.text += "\n";
            trade_log.text += "No Credit";
        }

    }



}
