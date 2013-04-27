using UnityEngine;
using System.Collections;

public class AudioCollision : MonoBehaviour {
	private RaycastHit hit;
	private GameObject player;
	private Transform c_transform;
	private AudioSource audio; 
	private float origVol;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
		c_transform = this.transform;
		audio =  this.GetComponent<AudioSource>();
		origVol = audio.minDistance;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 origin = c_transform.position;
		Vector3 dest = player.transform.position;
		float pDist = Vector3.Distance(origin, dest);
		Debug.DrawRay(origin, (dest - origin), Color.green);
		Physics.Raycast(origin, Vector3.Normalize(dest - origin), out hit, pDist);
		if (hit.transform && hit.transform.gameObject != player) {
			Debug.DrawRay(origin, (hit.point - origin), Color.red);

			float cDist = Vector3.Distance(origin, hit.point);

			//audio.maxDistance = (cDist / pDist) * origVol;
			audio.minDistance = cDist;
		} else {
			audio.minDistance = origVol;
		}
	}
}
