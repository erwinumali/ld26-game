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

		tempVector3.x=-0.5f;
		tempVector3.y=0.5f;
		tempVector3.z=-0.5f;
		corner[0]=tempVector3;
		tempVector3.z=0.4999f;
		corner[1]=tempVector3;
		tempVector3.z=0.5f;
		corner[2]=tempVector3;
		tempVector3.y=-0.4999f;
		corner[3]=tempVector3;
		tempVector3.y=-0.5f;
		corner[4]=tempVector3;
		tempVector3.z=-0.4999f;
		corner[5]=tempVector3;
		tempVector3.z=-0.5f;
		corner[6]=tempVector3;
		tempVector3.y=0.4999f;
		corner[7]=tempVector3;
		tempVector3.y=0.5f;
		corner[8]=tempVector3;
		tempVector3.x=0.4999f;
		corner[9]=tempVector3;
		tempVector3.x=0.5f;
		corner[10]=tempVector3;
		tempVector3.y=-0.4999f;
		corner[11]=tempVector3;
		tempVector3.y=-0.5f;
		corner[12]=tempVector3;
		tempVector3.x=-0.4999f;
		corner[13]=tempVector3;
		tempVector3.x=-0.5f;
		corner[14]=tempVector3;
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
