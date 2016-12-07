using UnityEngine;
using System.Collections;

public class EnergySpawner : MonoBehaviour
{

	void OnTriggerEnter(Collider trigger) {
		if (trigger.gameObject.tag == "Energy") {
			Destroy (trigger.gameObject);
		}
	}
}

