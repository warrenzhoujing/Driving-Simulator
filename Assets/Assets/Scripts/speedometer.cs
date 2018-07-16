using UnityEngine;
using UnityEngine.UI;

public class speedometer : MonoBehaviour {
    public Rigidbody player;
    public Text mph_text;

    void Update () {
        mph_text.text = (player.velocity.magnitude * 2).ToString("0") + "mph";  	
	}
}
