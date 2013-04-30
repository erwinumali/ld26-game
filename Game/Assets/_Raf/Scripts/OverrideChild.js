private var detail : int = 20;
private var c_render : LineRenderer;
private var dist:float;
private var lightningThickness : float = 0;
private var c_overrideParent:OverrideParent;
private var endPoint : Transform;
private var startPoint:Transform;

private var tempVector:Vector3;
private var player:Transform;
private var c_transform:Transform;
private var bool:boolean=false;
private var done:boolean=false;

private var distToPlayer:float=0;
private var timeScript:OverrideTime;
private var bool1:boolean=true;
//private var bool2:boolean=false;

function Start(){
	transform.parent.GetComponent(WireframeParent).enabled=false;
	GetComponent(WireframeChild).enabled=false;
	player=GameObject.FindGameObjectWithTag("Player").transform;
	c_render= GetComponent(LineRenderer);
	c_wireframeParent=transform.parent.gameObject.GetComponent(WireframeParent);
	c_render.sharedMaterial.SetColor("_TintColor", c_wireframeParent.GetColor());
	dist=10;
	endPoint=transform.FindChild("EndPoint");
	startPoint=transform.FindChild("StartPoint");
	c_render.SetPosition(0,startPoint.position);
	c_render.SetVertexCount(2);
	c_render.SetPosition(1, endPoint.position);
	c_render.sharedMaterial.mainTextureScale.x = dist/c_wireframeParent.GetSmoothness();
	c_transform=transform;
	distToPlayer=Vector3.Distance(c_transform.position, player.position);
	timeScript=GameObject.FindGameObjectWithTag("Player").GetComponent(OverrideTime);
	c_render.enabled=false;
	
}
function Update(){
	if(timeScript!=null && timeScript.GetDistance()>=distToPlayer && !bool) bool=true;
	if(bool){
		c_render.enabled=true;
		if(lightningThickness<.39 && bool1){
			lightningThickness=Mathf.Lerp(lightningThickness,.4f,Time.deltaTime*2);
		}else{
			lightningThickness=Mathf.Lerp(lightningThickness,0,Time.deltaTime*2);
			bool1=false;
			if(lightningThickness<=.01){
				done=true;
			}
		}
		c_render.SetWidth(lightningThickness, lightningThickness);
		c_render.sharedMaterial.mainTextureOffset.x = Random.value;
		if(done){
			transform.parent.GetComponent(WireframeParent).enabled=true;
			GetComponent(WireframeChild).enabled=true;
			c_render.enabled=false;
			Destroy(GetComponent(OverrideChild));
		}
	}
}

function Go(){
	bool=true;
}