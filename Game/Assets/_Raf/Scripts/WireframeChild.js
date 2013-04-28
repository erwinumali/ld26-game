private var detail : int = 20;
private var c_render : LineRenderer;
private var dist:float;
private var lightningThickness : float = 1.5;
private var c_wireframeParent:WireframeParent;
public var endPoint : Transform;
public var startPoint:Transform;

private var tempVector:Vector3;
private var player:Transform;


function Start(){
	player=GameObject.FindGameObjectWithTag("Player").transform;
	c_render= GetComponent(LineRenderer);
	c_wireframeParent=transform.parent.gameObject.GetComponent(WireframeParent);
	c_render.material.SetColor("_TintColor", c_wireframeParent.GetColor());
}
function Update () {

	dist = Vector3.Distance(startPoint.position, endPoint.position);
	var hit:RaycastHit;
	if(Physics.Raycast(transform.position, player.position-transform.position, hit)){
		Debug.DrawRay(transform.position, player.position-transform.position, Color.green);
		if(hit.transform.IsChildOf(transform.parent)) lightningThickness=0;
		else lightningThickness=c_wireframeParent.GetShade();
	}
	c_render.SetWidth(lightningThickness, lightningThickness);
	c_render.SetPosition(0,startPoint.position);
	
	c_render.SetVertexCount(2);
	c_render.material.mainTextureOffset.x = Random.value;
	c_render.material.mainTextureScale.x = dist/c_wireframeParent.GetSmoothness();
	positionDistance = dist;
	c_render.SetPosition(1, endPoint.position);

}