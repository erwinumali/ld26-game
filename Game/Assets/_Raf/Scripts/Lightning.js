//Lightning.js
var meshDetail : int = 5;
var random : float = 1;
var smoothness : float = 30;
var lightningThickness : float = 1.5;


var lightningColor : Color = Color.cyan; 

var endPoint : Transform;
var rayCastEndPoint = false;
var oneShot = false;

var noHitLightningDistance : float = 200;
var oneShotFadeSpeed : float = .1;
var oneShotLightFadeSpeed : float = .2;

private var detail : int = 20;
private var startDestroy = false;
private var firstPosSet = false;
public var end2:Transform;

var start:Transform;
var modColor = lightningColor;
var dist:float;

function Start(){
	
	renderer.material.SetColor("_TintColor", modColor);
}
function Update () {

	dist = Vector3.Distance(transform.position, endPoint.position);
	detail = dist * meshDetail / 40;
	

	var GlowWidthRandom = Random.Range(9, 13);
	
	var render : LineRenderer = GetComponent(LineRenderer);
	
	render.SetWidth(lightningThickness, lightningThickness);
	render.SetPosition(0,start.position);
	
	if(detail > 0){		
		render.SetVertexCount(detail + 1);
		renderer.material.mainTextureOffset.x = Random.value;
		renderer.material.mainTextureScale.x = dist/smoothness;
		positionDistance = dist / detail;
	}
	for(i = 1; i < detail + 1; i ++){
		if(i == detail){
			render.SetPosition(i, end2.position);
		}
	}
		
}