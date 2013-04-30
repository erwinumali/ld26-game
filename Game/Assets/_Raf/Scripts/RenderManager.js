#pragma strict
function OnBecameVisible(){
	gameObject.GetComponent(WireframeChild).enabled=true;
}
function OnBecameInvisible(){
	gameObject.GetComponent(WireframeChild).enabled=false;
}