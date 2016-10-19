using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

    float distance = 0.09F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad % 10 == 1 && transform.position.x <= 11)
        {
            transform.position += transform.right * distance;
        }
    }
}
