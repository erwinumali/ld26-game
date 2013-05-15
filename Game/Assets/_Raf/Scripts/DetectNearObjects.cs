using UnityEngine;
using System.Collections;

public class DetectNearObjects : MonoBehaviour {
	public float vision;
	private Transform c_transform;
	private float distance=0;
	private int mask;

	void Start () {
		c_transform=transform;
		mask=1<<9;
	}
	
	void Update () {
		Collider[] colliders = Physics.OverlapSphere(transform.position,vision*1.25f,mask);
		foreach(Collider col in colliders){
			distance=Vector3.Distance(c_transform.position, col.ClosestPointOnBounds(c_transform.position));
			LineRenderer lineRenderer=col.GetComponent<LineRenderer>();
			WireFrame wireFrame=col.GetComponent<WireFrame>();
			if(distance<=vision){
				wireFrame.enabled=true;
				lineRenderer.enabled=true;
				if(wireFrame.enabled && lineRenderer.enabled){
					wireFrame.SetWireFrame(distance);
				}
			}else{
				if(wireFrame.enabled && lineRenderer.enabled) wireFrame.SetWireFrame(0);
				wireFrame.enabled=false;
				lineRenderer.enabled=false;
			}
		}
		
	}
	
	public float GetMaxVision(){
		return vision;	
	}
}
