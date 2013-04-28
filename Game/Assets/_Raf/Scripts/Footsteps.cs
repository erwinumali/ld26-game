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
		}else if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
			if(grounded!=true){
				audioSource.clip = audioClip[1];
				grounded=true;	
			}
			// don't play if step sfx is still playing
			if(!audioSource.isPlaying) audioSource.Play();
		}else{
			// if from jumping state to ground without inputs stop sound
			if(grounded==false){
				// you can input landing sfx here
				// ex: audioSource.clip = audioClip[2];
				// add another element in audio clip
				audioSource.Stop();	
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
