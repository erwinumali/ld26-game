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
			WireFrame wireFrame=col.GetComponent<WireFrame>();
			// get least distance still gets from non has parent colliders
			if(wireFrame.HasParent()){
				distance=GetLeastDistance(colliders);
				if(distance<=vision) wireFrame.GetParent().SetWireFrames(distance);
				else wireFrame.GetParent().SetWireFrames(0);
			}else{
				distance=Vector3.Distance(c_transform.position, col.ClosestPointOnBounds(c_transform.position));
				LineRenderer lineRenderer=col.GetComponent<LineRenderer>();
				if(distance<=vision){
					wireFrame.enabled=true;
					lineRenderer.enabled=true;
					wireFrame.SetWireFrame(distance);
				}else{
					if(wireFrame.enabled && lineRenderer.enabled) wireFrame.SetWireFrame(0);
					wireFrame.enabled=false;
					lineRenderer.enabled=false;
				}
			}
		}
	}
	
	public float GetMaxVision(){
		return vision;	
	}
	
//	private Vector3 center;
	private float GetLeastDistance(Collider[] colliders){
		float distance=0;
		int counter=0;
		foreach(Collider col in colliders){
			if(col.GetComponent<WireFrame>().HasParent()){
				if(counter==0){
					distance=Vector3.Distance(c_transform.position, col.ClosestPointOnBounds(c_transform.position));
					counter=1;
				}else{
					if(distance>=Vector3.Distance(c_transform.position, col.ClosestPointOnBounds(c_transform.position))){
						distance=Vector3.Distance(c_transform.position, col.ClosestPointOnBounds(c_transform.position));	
					}
				}
			}
		}
		return distance;
	}
	
}
