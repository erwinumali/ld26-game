using UnityEngine;
using System.Collections;

public class WireFrameParent : MonoBehaviour {
	WireFrame[] wireFrame;
	void Start () {
		wireFrame=GetComponentsInChildren<WireFrame>();
		foreach(WireFrame wf in wireFrame){
			wf.SetHasParent(true);
		}
	}
	
	/*
	public void SetWireFrame(float distance){
		if(c_lineRenderer){
			tempVector3.x=((maxDistance-distance)/maxDistance)*thickness;
			c_lineRenderer.SetWidth(tempVector3.x, tempVector3.x);
			tempVector3.x=r*Random.value*3;
			c_lineRenderer.sharedMaterial.mainTextureScale = tempVector3;
		}
	}*/
	
}
