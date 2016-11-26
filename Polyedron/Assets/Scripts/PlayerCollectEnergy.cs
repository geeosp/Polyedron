using UnityEngine;
using System.Collections;

public class PlayerCollectEnergy : MonoBehaviour
{
	// Use this for initialization
	void Start () {

	}

	void OnCollisionEnter2D(Collision2D col) {
		Debug.Log("Collision: " + col.gameObject.name);
		if (col.gameObject.tag == "Player") {
			Destroy(gameObject);
		}
	}

}

