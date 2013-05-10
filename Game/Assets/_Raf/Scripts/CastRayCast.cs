using UnityEngine;
using System.Collections;

public class CastRayCast : MonoBehaviour {
	private Transform player;
	// Use this for initialization
	void Start () {
		player=GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if(Physics.Raycast(transform.position,Vector3.Normalize(player.position-transform.position), out hit, Vector3.Distance(transform.position,player.position))){
			Debug.DrawRay(transform.position, hit.point-transform.position,Color.red);
			print(1+" "+Vector3.Distance(player.position,transform.position));
			print(2+" "+Vector3.Distance(hit.point,player.position));
		}
	}
}
