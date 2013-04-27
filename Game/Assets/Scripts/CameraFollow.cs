using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform toFollow;
	public float distance;

	private Vector3 tp;
	
	// Update is called once per frame
	void Update () {
		tp = toFollow.position;
		tp.y += distance;
		tp.z -= 5.0f;
		this.transform.position = tp;
	}
}
