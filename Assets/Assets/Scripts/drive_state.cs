using UnityEngine;
using UnityEngine.UI;

public class drive_state : MonoBehaviour {
    public Text drive_s;

	void Update () {
        if (GameObject.Find("jeep").GetComponent<car_movement>().reverse)
        {
            drive_s.text = "Reverse";
        }
        else
        {
            drive_s.text = "Drive";   
        }
	}
}
