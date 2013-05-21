using UnityEngine;
using System.Collections;

public class WireFrameParent : MonoBehaviour {
	private Transform[] tr;
	private WireFrame wf;
	private LineRenderer lr;
	private Vector3 tempVector3;
	
	public float roughness = 0;
	public float thickness = 0;
	private float maxDistance=0;
	void Start () {
		tr=transform.GetComponentsInChildren<Transform>();
		for(int i=1 ; i<tr.Length ; i++) tr[i].GetComponent<WireFrame>().SetParent(this);
		maxDistance=GameObject.FindGameObjectWithTag("Player").GetComponent<DetectNearObjects>().GetMaxVision();
		tempVector3=Vector3.one;
	}
	public void SetWireFrames(float distance){
		for(int i=1 ; i<tr.Length ; i++){
			wf=tr[i].GetComponent<WireFrame>();
			lr=tr[i].GetComponent<LineRenderer>();
			
			if(distance!=0){
				if(!wf.enabled) wf.enabled=true;
				if(!lr.enabled) lr.enabled=true;
			}else{
				if(wf.enabled) wf.enabled=false;
				if(lr.enabled) lr.enabled=false;
			}
			if(wf.enabled && lr.enabled){
				tempVector3.x=((maxDistance-distance)/maxDistance)*thickness;
				lr.SetWidth(tempVector3.x, tempVector3.x);
				tempVector3.x=roughness*Random.value*3;
				lr.sharedMaterial.mainTextureScale = tempVector3;
			}
		}
	}
}
