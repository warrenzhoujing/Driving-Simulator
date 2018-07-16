using UnityEngine;

public class game_manager : MonoBehaviour {
    public GameObject death_screen;
    public GameObject driver_meter;
    public GameObject jeep;
    public void retry()
    {
        death_screen.SetActive(false);
        driver_meter.SetActive(true);
        jeep.transform.position = new Vector3(1.96f, 1.437f, 0f);
        jeep.transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }
}
