
using System.Collections;
using TMPro;
using UnityEngine;

public class BuyButtonLogic : MonoBehaviour {

    public GameObject energy;
    public GameObject credits;
    public TextMeshProUGUI trade_log;

    void Start() {
        StartCoroutine(fade_out_trade_log());
        trade_log.text = "";
    }

    void OnEnable() {
        StartCoroutine(fade_out_trade_log());
        trade_log.text = "";
    }

    void OnDisable() {
        StopAllCoroutines();
    }

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

    IEnumerator fade_out_trade_log() {
        while (true) {
            trade_log.color = new Color(trade_log.color.r, trade_log.color.g, trade_log.color.b, 1f);
            trade_log.text = "";
    

            yield return new WaitForSeconds(4f);

            float alpha = 1f;
            while (alpha > 0f) {
                alpha -= Time.deltaTime;
                trade_log.color = new Color(trade_log.color.r, trade_log.color.g, trade_log.color.b, alpha);
                yield return null;
            }
        }
    }
}
