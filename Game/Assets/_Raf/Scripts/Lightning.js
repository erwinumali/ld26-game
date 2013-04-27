//Lightning.js

private var detail : int = 20;
private var c_render : LineRenderer;
private var dist:float;

public var meshDetail : int = 5;
public var smoothness : float = 30;
public var lightningThickness : float = 1.5;
public var lightningColor : Color; 
public var endPoint : Transform;
public var startPoint:Transform;
private var c_lightningShade:LightningShade;


function Start(){
	c_render= GetComponent(LineRenderer);
	c_lightningShade=transform.parent.gameObject.GetComponent(LightningShade);
	c_render.material.SetColor("_TintColor", lightningColor);
	//print(transform.parent.GetComponent("LightningShade"));
}
function Update () {

	dist = Vector3.Distance(startPoint.position, endPoint.position);
	detail = 1;
	
	lightningThickness=c_lightningShade.GetShade();
	c_render.SetWidth(lightningThickness, lightningThickness);
	c_render.SetPosition(0,startPoint.position);
	
	if(detail > 0){		
		c_render.SetVertexCount(detail + 1);
		c_render.material.mainTextureOffset.x = Random.value;
		c_render.material.mainTextureScale.x = dist/smoothness;
		positionDistance = dist / detail;
	}
	for(i = 1; i < detail + 1; i ++){
		if(i == detail){
			c_render.SetPosition(i, endPoint.position);
		}
	}
}
public function ASDF(){
}