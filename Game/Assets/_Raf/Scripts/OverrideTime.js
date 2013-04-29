#pragma strict
private var distance:float=0;


function Update () {
	distance+=.3f;
}

public function GetDistance(){
	return distance;
}