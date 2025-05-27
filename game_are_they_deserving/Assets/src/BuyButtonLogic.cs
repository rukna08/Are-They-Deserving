
using UnityEngine;

public class BuyButtonLogic : MonoBehaviour {

    public GameObject energy;
    public GameObject credits;
    
    public void buy_item() {
        
        if (credits.GetComponent<Credits>().credits > 0) {
            if (transform.parent.name == "Energy") {
                Debug.Log("Bought 100 energy for 1 credit");
                credits.GetComponent<Credits>().credits -= 1;
                energy.GetComponent<Energy>().energy += 100f;
            }
        } else {
            Debug.Log("No Credit.");
        }

    }

}
