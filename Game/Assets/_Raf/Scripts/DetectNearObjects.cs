using UnityEngine;
using System.Collections;

public class DetectNearObjects : MonoBehaviour {
	private Transform c_transform;
	private Collider[] colliders;
	public float vision=0;
	private int mask;
	void Start () {
		c_transform=transform;
		mask=1<<9;
	}
	
	void Update () {
		colliders=Physics.OverlapSphere(c_transform.position,vision*1.25f,mask);
		foreach(Collider col in colliders){
			float distance=Vector3.Distance(c_transform.position, col.transform.position);
			LineRenderer lineRenderer=col.GetComponent<LineRenderer>();
			WireFrame wireFrame=col.GetComponent<WireFrame>();
			if(distance<=vision){
				lineRenderer.enabled=true;
				wireFrame.enabled=true;
			}else{
				lineRenderer.enabled=false;
				wireFrame.enabled=false;
			}
		}
		
	}
	
	void OnDrawGizmosSelected () {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere (c_transform.position, vision);
    }
	
	public float GetVision(){
		return vision;
	}
}
