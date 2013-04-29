#pragma strict
private var shade:float=0;
private var c_transform:Transform;
private var player:Transform;
private var distance:float;
public var maxDistance:float=5;
public var thickness:float=.02;
public var lightColor:Color;
public var smoothness:float=1;

function Start(){
	c_transform=transform;
	player=GameObject.FindGameObjectWithTag("Player").transform;
	shade=.05;
}

function GetShade(){
	distance=Vector3.Distance(c_transform.position,player.position);
	if(distance<=maxDistance) shade=(maxDistance-distance)*thickness;
	else shade=0;	
	return shade;

}

function GetColor(){
	return lightColor;
}

function GetSmoothness(){
	return smoothness;
}

function GetMaxDistance(){
	return maxDistance;
}