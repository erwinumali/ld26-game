#pragma strict
	public var c_render:LineRenderer;
function Start () {
	c_render=GameObject.FindGameObjectWithTag("Respawn").GetComponent(LineRenderer);
}

function Update () {

}