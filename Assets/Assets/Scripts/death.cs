using UnityEngine;

public class death : MonoBehaviour {
    public GameObject canvas;
    public GameObject death_screen;
	void OnCollisionEnter(Collision col)
	{
        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "House"){
            canvas.SetActive(false);
            death_screen.SetActive(true);
        }
	}
}
