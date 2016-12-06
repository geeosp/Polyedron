using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour {

	public static int playerSpeed = 10;
	/* Use this for initialization
	void Start () {
		
	}
	*/

	// Update is called once per frame
	void FixedUpdate () {
		gameObject.transform.Translate (Vector3.right * playerSpeed * Time.fixedDeltaTime);
	}
}
