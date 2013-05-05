using UnityEngine;
using System.Collections;

public class WireFrameChild : MonoBehaviour {
	private float roughness = 0;
	private float thickness = 0;
	private LineRenderer c_lineRenderer;
	private Vector3[] corner;
	public Color color;
	private Transform c_parentTransform;
	private Vector3 tempVector3;
	
	void Start () {
		c_lineRenderer=GetComponent<LineRenderer>();
		c_parentTransform=transform.parent;
		c_lineRenderer.sharedMaterial.SetColor("_TintColor", color);
		c_lineRenderer.SetVertexCount(15);
		corner=new Vector3[15];
		tempVector3.x=-1;
		tempVector3.y=-1;
		tempVector3.z=1;
		corner[0]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		tempVector3.z=-.999f;
		corner[1]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		tempVector3.z=-1;
		corner[2]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		tempVector3.y=.999f;
		corner[3]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		tempVector3.y=1;
		corner[4]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		tempVector3.z=.999f;
		corner[5]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		tempVector3.z=1;
		corner[6]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		tempVector3.y=-.999f;
		corner[7]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		tempVector3.y=-1;
		corner[8]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		tempVector3.x=.999f;
		corner[9]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		tempVector3.x=1;
		corner[10]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		tempVector3.y=.999f;
		corner[11]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		tempVector3.y=1;
		corner[12]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		tempVector3.x=-.999f;
		corner[13]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		tempVector3.x=-1;
		corner[14]=c_parentTransform.position+Vector3.Scale(c_parentTransform.localScale / 2, tempVector3);
		for(int i=0 ; i<15 ; i++) c_lineRenderer.SetPosition(i, corner[i]);
		
	}
	
	void Update () {
		c_lineRenderer.sharedMaterial.mainTextureScale = tempVector3;
		c_lineRenderer.SetWidth(thickness, thickness);
	}
	
	public void SetTextureScale(float textureScale){
		tempVector3.x=textureScale;
	}
	
	public void SetThickness(float thickness){
		this.thickness=thickness;	
	}
}
