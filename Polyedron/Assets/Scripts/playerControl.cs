using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {

	public float force = 1000.0f;
	public Rigidbody2D rb;
	public bool jump = true; 

	// Update is called once per frame
	void Update () {
		if (jump && Input.GetButton ("Jump")) {
			Jump ();
			jump = false;
		}
	}

	void Jump() {
		GetComponent<Rigidbody2D>().AddForce(new Vector3(0, force, 0), ForceMode2D.Impulse); 
	}

	void OnCollisionEnter2D(Collision2D other) {
			jump = true;
	}
}
