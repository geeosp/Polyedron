using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

    float distance = 0.1F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.right * distance;
    }
}
