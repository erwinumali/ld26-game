using UnityEngine;
using System.Collections;

public class DetectPlayer : MonoBehaviour {
	private Collider col;
	private Transform c_transform;
	private Transform c_playerTransform;
	private LineRenderer c_lineRenderer;
	private WireFrame c_wireFrame;
	private int mask;
	private float distance;
	public float maxDistance;
	
	void Start () {
		c_transform=transform;
		c_playerTransform=GameObject.FindGameObjectWithTag("Player").transform;
		c_lineRenderer=gameObject.GetComponent<LineRenderer>();
		c_wireFrame=gameObject.GetComponent<WireFrame>();
	}
	
	void Update () {
		distance=Vector3.Distance(c_transform.position, c_playerTransform.position);
		if(distance<=maxDistance){
			c_lineRenderer.enabled=true;
			c_wireFrame.enabled=true;
			if(c_wireFrame.enabled && c_lineRenderer.enabled) c_wireFrame.SetDistance(distance);
		}else{
			if(c_wireFrame.enabled && c_lineRenderer.enabled) c_wireFrame.SetDistance(0);
			c_wireFrame.enabled=false;
			c_lineRenderer.enabled=false;
		}
	}
}
