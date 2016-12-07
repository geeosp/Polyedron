using UnityEngine;
using System.Collections;

public class RotateObj : MonoBehaviour
{
	public int rotateSpeed;

	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate (Vector3.up * rotateSpeed * Time.fixedDeltaTime);
	}
}

