using UnityEngine;
using System.Collections;

public class DetectNearObjects : MonoBehaviour {
	private Transform c_transform;
	private Collider[] colliders;
	public float radius=0;
	private int mask;
	void Start () {
		c_transform=transform;
		mask=1<<9;
	}
	
	void Update () {
		colliders=Physics.OverlapSphere(c_transform.position,radius*1.25f,mask);
		foreach(Collider col in colliders){
			float distance=Vector3.Distance(c_transform.position, col.transform.position);
			LineRenderer[] lineRenderer=col.GetComponentsInChildren<LineRenderer>();
			WireFrameChild[] wireFrameChild=col.GetComponentsInChildren<WireFrameChild>();
			WireFrameParent wireFrameParent=col.GetComponent<WireFrameParent>();
			if(distance<=radius){
				foreach(LineRenderer lr in lineRenderer)lr.enabled=true;
				foreach(WireFrameChild wfc in wireFrameChild) wfc.enabled=true;
				wireFrameParent.enabled=true;
			}else{
				foreach(LineRenderer lr in lineRenderer) lr.enabled=false;
				foreach(WireFrameChild wfc in wireFrameChild) wfc.enabled=false;
				wireFrameParent.enabled=false;
			}
		}
		
	}
	
	void OnDrawGizmosSelected () {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere (c_transform.position, radius);
    }
}
