private var detail : int = 20;
private var c_render : LineRenderer;
private var dist:float;
private var lightningThickness : float = 1.5;
private var c_wireframeParent:WireframeParent;
public var endPoint : Transform;
public var startPoint:Transform;


function Start(){
	c_render= GetComponent(LineRenderer);
	c_wireframeParent=transform.parent.gameObject.GetComponent(WireframeParent);
	c_render.material.SetColor("_TintColor", c_wireframeParent.GetColor());
}
function Update () {

	dist = Vector3.Distance(startPoint.position, endPoint.position);

	lightningThickness=c_wireframeParent.GetShade();
	c_render.SetWidth(lightningThickness, lightningThickness);
	c_render.SetPosition(0,startPoint.position);
	
	c_render.SetVertexCount(2);
	c_render.material.mainTextureOffset.x = Random.value;
	c_render.material.mainTextureScale.x = dist/c_wireframeParent.GetSmoothness();
	positionDistance = dist;
	c_render.SetPosition(1, endPoint.position);

}