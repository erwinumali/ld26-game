private var detail : int = 20;
private var c_render : LineRenderer;
private var dist:float;
private var lightningThickness : float = 1.5;
private var c_wireframeParent:WireframeParent;
public var endPoint : Transform;
public var startPoint:Transform;

private var tempVector:Vector3;
private var player:Transform;
private var c_transform:Transform;


function Start(){
	player=GameObject.FindGameObjectWithTag("Player").transform;
	c_render= GetComponent(LineRenderer);
	c_wireframeParent=transform.parent.gameObject.GetComponent(WireframeParent);
	c_render.material.SetColor("_TintColor", c_wireframeParent.GetColor());
	dist=c_wireframeParent.GetMaxDistance();
	c_render.SetPosition(0,startPoint.position);
	c_render.SetVertexCount(2);
	c_render.SetPosition(1, endPoint.position);
	
	c_render.material.mainTextureScale.x = dist/c_wireframeParent.GetSmoothness();
	c_transform=transform;
}
private var timer:float=0;
function Update () {
	timer+=Time.deltaTime;
	var hit:RaycastHit;
	if(Physics.Raycast(c_transform.position, player.position-c_transform.position, hit,dist)){
		//Debug.DrawRay(transform.position, player.position-transform.position, Color.green);
		if(hit.transform.tag=="Player"){
			if(c_render.enabled!=true) c_render.enabled=true;
			lightningThickness=c_wireframeParent.GetShade();
			c_render.SetWidth(lightningThickness, lightningThickness);
			c_render.material.mainTextureOffset.x = Random.value;
			//positionDistance = dist;
		}else {
			c_render.enabled=false;
			lightningThickness=0;
		}
	}else{
		if(c_render.enabled!=false) c_render.enabled=false;
		lightningThickness=0;
	}
}