using UnityEngine;
using System.Collections;

/*
 * AudioClip[0] for jumping sfx
 * AudioClip[1] for running sfx
 * no sfx for 2 onwards yet
 */


public class Footsteps : MonoBehaviour {
	private AudioSource audioSource;
	private CharacterMotor c_characterMotor;
	private bool grounded=false;
	public AudioClip []audioClip;
	
 
    void Start(){
		audioSource = gameObject.AddComponent<AudioSource>();
		c_characterMotor=gameObject.GetComponent<CharacterMotor>();
    }
 
    void Update(){
		if(!c_characterMotor.IsGrounded()){
			if(grounded!=false){
				audioSource.clip = audioClip[0];
				audioSource.Play();
				grounded=false;
			}
		}else{
			if(grounded==false){
					audioSource.clip = audioClip[2];
					if(!audioSource.isPlaying) audioSource.Play();
					grounded=true;
			}
			else if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
				
				if(!audioSource.isPlaying){
					if(audioSource.clip!=audioClip[1]) audioSource.clip = audioClip[1];
					audioSource.Play();
				}
			}
			
		}
    }
	
	public void SetFoot(AudioClip clip){
		audioClip[1]=clip;
		audioSource.clip = audioClip[1];
	}
	
	public AudioClip GetFoot(){
		return audioClip[1];
	}
}
