using UnityEngine;
using System.Collections;

public class CarMove : MonoBehaviour {
	
	public GameObject startPoint;
	public GameObject endPoint;
	
	public float rate = 10.0f;
	public float delayRange = 50.0f;
	public float delay;
	public float counter;
	
	private Transform car;
	
	// Use this for initialization
	void Start () {
		car = transform;
		car.position = startPoint.transform.position;
		counter = 0;
		delay = Random.value * delayRange;

	}
	
	// Update is called once per frame
	void Update () {
		if(car.position != endPoint.transform.position){
			car.position = Vector3.MoveTowards(car.position, endPoint.transform.position, rate * Time.deltaTime);
		} else {
			if (counter < delay) {
				counter += 5.0f * Time.deltaTime;
			} else {
				car.position = startPoint.transform.position;
				delay = Random.value * delayRange;
				counter = 0;
			}
		}
	}
}
