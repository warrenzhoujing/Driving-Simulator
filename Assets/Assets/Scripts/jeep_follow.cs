using UnityEngine;

public class jeep_follow : MonoBehaviour {
    public Transform T;
	void Update () {
        transform.rotation = T.rotation;
        transform.position = new Vector3(T.position.x, T.position.y);
                                         }
}
