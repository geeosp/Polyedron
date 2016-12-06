using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControl : MonoBehaviour {

	public float force = 100;
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
		GetComponent<Rigidbody2D>().AddForce(new Vector3(0, force, 0), ForceMode2D.Force); 
	}

	void OnCollisionEnter2D(Collision2D other) {
			jump = true;
	}
}
