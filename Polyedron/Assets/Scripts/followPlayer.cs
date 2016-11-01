using UnityEngine;
using System.Collections;

public class followPlayer : MonoBehaviour {

	private GameObject player;
	public float cameraSpeed = 2.5f;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}

	void FixedUpdate () {
		//X position follow
		Vector3 camPos = transform.position;
		camPos.x = player.transform.position.x - -7.5f;
		transform.position = Vector3.Lerp(transform.position, camPos, 3 * Time.fixedDeltaTime);
		
		//Y Position follow
		camPos.y = player.transform.position.y + 2;
		transform.position = Vector3.Lerp (transform.position, camPos, 3.0f * Time.fixedDeltaTime);
	}
}
