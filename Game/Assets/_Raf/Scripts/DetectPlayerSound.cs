using UnityEngine;
using System.Collections;

public class DetectPlayerSound : MonoBehaviour {
	private Transform c_transform;
	private Transform c_playerTransform;
	private Footsteps c_playerFootsteps;
	private bool inside=false;
	
	public float radius=3f;
	public AudioClip audioClip;
	private AudioClip prevAudioClip;
	
	void Start () {
		c_playerTransform=GameObject.FindGameObjectWithTag("Player").transform;
		c_transform=transform;
		c_playerFootsteps=c_playerTransform.GetComponent<Footsteps>();
	}
	
	void Update () {
		if( Physics.Raycast(c_transform.position,c_playerTransform.position-c_transform.position,radius) ){
			Debug.DrawRay(c_transform.position, c_playerTransform.position-c_transform.position, Color.red);
			if(inside==false){
				print ("inside perimeter");
				prevAudioClip=c_playerFootsteps.GetFoot();
				c_playerFootsteps.SetFoot(audioClip);
				inside=true;
			}
		}else{
			Debug.DrawRay(c_transform.position, c_playerTransform.position-c_transform.position, Color.green);
			if(inside==true){
				print ("outside perimeter");
				c_playerFootsteps.SetFoot(prevAudioClip);
				inside=false;
			}
		}
	}

	void OnDrawGizmosSelected (){
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere (transform.position, radius);
    }
}
