using UnityEngine;
using System.Collections;

public class TextHandler : MonoBehaviour {
	private Color color;
	private Renderer c_renderer;
	private float distance=0;
	private Transform c_playerTransform;
	private Transform c_transform;
	public float maxDistance=0;
	
	// Use this for initialization
	void Start () {
		color=GetComponent<TextMesh>().renderer.sharedMaterial.color;
		c_playerTransform=GameObject.FindGameObjectWithTag("Player").transform;
		print (c_playerTransform);
		c_transform=transform;
		print (c_transform);
	}
	
	// Update is called once per frame
	void Update () {
		distance=Vector3.Distance(c_playerTransform.position,c_transform.position);
		color.a= (maxDistance-distance)/maxDistance;
		renderer.sharedMaterial.color=color;
	}
}
