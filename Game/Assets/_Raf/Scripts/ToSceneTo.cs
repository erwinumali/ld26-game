using UnityEngine;
using System.Collections;

public class ToSceneTo : MonoBehaviour {
	private Transform c_transform;
	private Transform c_playerTransform;
	
	// Use this for initialization
	void Start () {
		c_transform=transform;
		c_playerTransform=GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if(Physics.Raycast(c_transform.position,c_playerTransform.position,out hit,5)){
			if(hit.transform.gameObject.tag=="Player")
				Application.LoadLevel ("TestScene1"); 
		}
	}
}
