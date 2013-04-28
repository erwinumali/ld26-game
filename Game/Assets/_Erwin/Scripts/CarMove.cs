using UnityEngine;
using System.Collections;

public class CarMove : MonoBehaviour {
	
	public GameObject startPoint;
	public GameObject endPoint;
	
	public float rate = 2.0f;
	
	private Transform car;
	
	// Use this for initialization
	void Start () {
		car = transform;
		car.position = startPoint.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(car.position != endPoint.transform.position){
			car.position = Vector3.MoveTowards(car.position, endPoint.transform.position, rate);
		} else {
			car.position = startPoint.transform.position;
		}
	}
}
