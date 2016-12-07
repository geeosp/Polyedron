using UnityEngine;
using System.Collections;

public class PlayerCollectEnergy : MonoBehaviour
{
        /*
	void OnCollisionEnter(Collision2D col) {


		Debug.Log("Collision: " + col.gameObject.name);
		if (col.gameObject.tag == "Player") {
			Destroy(gameObject);
			DataManagement.datamanagement.increaseEnergy();
	}   
		}*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            DataManagement.datamanagement.increaseEnergy();

        }
    }
    }

