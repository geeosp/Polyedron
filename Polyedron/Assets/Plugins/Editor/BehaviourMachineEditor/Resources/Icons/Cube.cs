using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

    float distance = 10.0F;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= transform.right * distance;
    }
}
