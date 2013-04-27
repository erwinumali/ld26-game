using UnityEngine;
using System.Collections;

public class Float : MonoBehaviour {
	public float amplitude = 1.0f;
	public float hoverSpeed = 1.0f;

	private Transform c_transform;
	private Vector3 v;

	// Use this for initialization
	void Start () {
		c_transform = transform;	
	}
	
	// Update is called once per frame
	void Update () {
		v = c_transform.position;
		v.y = v.y + amplitude * Mathf.Sin(hoverSpeed * Time.time);
		c_transform.position = v;
	}
}