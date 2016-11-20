using UnityEngine;
using System.Collections;

public class PlayerCollectEnergy : MonoBehaviour
{
	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D trigger) {
		Debug.Log("Trigger: " + trigger.gameObject.name);
		if (trigger.tag == "Energy") {
			Destroy (trigger.gameObject);
		}
	}
}

