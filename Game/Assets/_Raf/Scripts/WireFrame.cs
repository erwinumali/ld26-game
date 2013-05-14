using UnityEngine;
using System.Collections;
public enum Type{
	Cube,
	Tile,
	Pyramid,
}
public class WireFrame : MonoBehaviour {
	public float roughness = 0;
	public float thickness = 0;
	private float maxDistance = 0;
	private float distance=0;
	private LineRenderer c_lineRenderer;
	private Transform c_playerTransform;
	private Transform c_transform;
	public Color color;
	private Vector3 tempVector3;
	public Type type;
	public bool boolean=false;
	
	void Start () {
		c_lineRenderer=GetComponent<LineRenderer>();
		c_playerTransform=GameObject.FindGameObjectWithTag("Player").transform;
		c_transform=transform;
		maxDistance=c_playerTransform.GetComponent<DetectNearObjects>().GetMaxDistance();
		c_lineRenderer.sharedMaterial.SetColor("_TintColor", color);
		
		Vector3[] corner;
		if(type==Type.Cube){
			corner=new Vector3[35];
			c_lineRenderer.SetVertexCount(35);
			tempVector3.x=-0.5f;
			tempVector3.y=-0.5f;
			tempVector3.z=-0.5f;
			corner[0]=tempVector3;
			tempVector3.y=0.4999f;
			corner[1]=tempVector3;
			tempVector3.y=0.5f;
			corner[2]=tempVector3;
			tempVector3.x=0.4999f;
			corner[3]=tempVector3;
			tempVector3.x=0.5f;
			corner[4]=tempVector3;
			tempVector3.y=-0.4999f;
			corner[5]=tempVector3;
			tempVector3.y=-0.5f;
			corner[6]=tempVector3;
			tempVector3.z=0.4999f;
			corner[7]=tempVector3;
			tempVector3.z=0.5f;
			corner[8]=tempVector3;
			tempVector3.y=0.4999f;
			corner[9]=tempVector3;
			tempVector3.y=0.5f;
			corner[10]=tempVector3;
			tempVector3.z=-0.4999f;
			corner[11]=tempVector3;
			tempVector3.z=-0.5f;
			corner[12]=tempVector3;
			tempVector3.y=-0.4999f;
			corner[13]=tempVector3;
			tempVector3.y=-0.5f;
			corner[14]=tempVector3;
			tempVector3.x=-0.4999f;
			corner[15]=tempVector3;
			tempVector3.x=-0.5f;
			corner[16]=tempVector3;
			tempVector3.y=0.4999f;
			corner[17]=tempVector3;
			tempVector3.y=0.5f;
			corner[18]=tempVector3;
			tempVector3.z=0.4999f;
			corner[19]=tempVector3;
			tempVector3.z=0.5f;
			corner[20]=tempVector3;
			tempVector3.y=-0.4999f;
			corner[21]=tempVector3;
			tempVector3.y=-0.5f;
			corner[22]=tempVector3;
			tempVector3.x=0.4999f;
			corner[23]=tempVector3;
			tempVector3.x=0.5f;
			corner[24]=tempVector3;
			tempVector3.y=0.4999f;
			corner[25]=tempVector3;
			tempVector3.y=0.5f;
			corner[26]=tempVector3;
			tempVector3.x=-0.4999f;
			corner[27]=tempVector3;
			tempVector3.x=-0.5f;
			corner[28]=tempVector3;
			tempVector3.y=-0.4999f;
			corner[29]=tempVector3;
			tempVector3.y=-0.5f;
			corner[30]=tempVector3;
			tempVector3.z=-0.4999f;
			corner[31]=tempVector3;
			tempVector3.z=-0.5f;
			corner[32]=tempVector3;
			tempVector3.y=0.4999f;
			corner[33]=tempVector3;
			tempVector3.y=0.5f;
			corner[34]=tempVector3;
			for(int i=0 ; i<corner.Length ; i++) c_lineRenderer.SetPosition(i, corner[i]);
		}else if(type==Type.Tile){
			c_lineRenderer.SetVertexCount(9);
			corner=new Vector3[9];
			tempVector3.x=0.5f;
			tempVector3.y=0.5f;
			tempVector3.z=0;
			corner[0]=tempVector3;
			tempVector3.y=-0.4999f;
			corner[1]=tempVector3;
			tempVector3.y=-0.5f;
			corner[2]=tempVector3;
			tempVector3.x=-0.4999f;
			corner[3]=tempVector3;
			tempVector3.x=-0.5f;
			corner[4]=tempVector3;
			tempVector3.y=0.4999f;
			corner[5]=tempVector3;
			tempVector3.y=0.5f;
			corner[6]=tempVector3;
			tempVector3.x=0.4999f;
			corner[7]=tempVector3;
			tempVector3.x=0.5f;
			corner[8]=tempVector3;
			for(int i=0 ; i<corner.Length ; i++) c_lineRenderer.SetPosition(i, corner[i]);	
		}
		tempVector3=Vector3.one;
	}
	
	public void SetWireFrame(float dist){
		tempVector3.x=((maxDistance-dist)/maxDistance)*thickness;
		c_lineRenderer.SetWidth(tempVector3.x, tempVector3.x);
		tempVector3.x=roughness*Random.value*10;
		c_lineRenderer.sharedMaterial.mainTextureScale = tempVector3;
	}
}
