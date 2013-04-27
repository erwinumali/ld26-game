#pragma strict
private var shade:float=0;
private var c_transform:Transform;
public var player:Transform;
private var dist:float;
function Start(){
	c_transform=transform;
}
function Update(){
	dist=Vector3.Distance(c_transform.position,player.position);
	if(dist<=5){
		shade=(5-dist)*.02;
	}else shade=0;
}
function GetShade(){
	return shade;
}