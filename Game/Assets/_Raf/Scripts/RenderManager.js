#pragma strict
function OnBecameVisible(){
	gameObject.GetComponent(WireframeChild).enabled=true;
	//Debug.Log("VISIBLE");
}
function OnBecameInvisible(){
	gameObject.GetComponent(WireframeChild).enabled=false;
	//Debug.Log("INVISIBLE");
}